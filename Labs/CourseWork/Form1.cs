using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Npgsql;
using NeuralNetwork;
using System.IO;


namespace CourseWork
{
    public partial class Form1 : Form
    {
        // змінні для зчитування з бд
        DataSet ds = new DataSet(); // множина даних для запиту №1
        DataSet ds2 = new DataSet(); // множина даних для запиту №2
        DataTable dt = new DataTable(); // таблиця даних для запиту №1
        DataTable dt2 = new DataTable(); // таблиця даних для запиту №2
        string[] ParametersNames; // назви параметрів керогену
        Stopwatch sWatch = new Stopwatch(); // клас для вимірювання часу навчання мережі BackPropagation
        Stopwatch sWatch2 = new Stopwatch(); // клас для вимірювання часу навчання мережі LVQ
        TimeSpan tSpan; // клас для перетворення даних про час навчання

        // змінні для створення таблиць із результатами роботи мережі (BackPropagation)
        DataTable ResultTrainBackPropagation; // результати роботи BackPropagation для навчальної вибірки
        DataTable ResultTestBackPropagation; //  результати роботи BackPropagation для тестової вибірки

        // змінні для створення таблиць із результатами роботи мережі (LVQ)
        DataTable ResultTrainLVQ; // результати роботи LVQ для навчальної вибірки
        DataTable ResultTestLVQ; //  результати роботи LVQ для тестової вибірки

        // навчальна вибірка
        int TRAINING_PATTERNS; // кількість паттернів у навчальній вибірці
        int PARAMETERS; // кількість параметрів керогену 
        int NUM_OF_CLUSTERS; // кількість кластерів керогену
        int TestAmount; // кількість випадкової вибірки для тестування мереж

        // Параметри BackPropagation
        int[] layerSizes; // кількість шарів та нейронів у шарах
        // активаційні функції для кожного шару
        TransferFunction[] TFuncs = new TransferFunction[3] {TransferFunction.None,
                                                               TransferFunction.BipolarSigmoid,
                                                               TransferFunction.BipolarSigmoid};
        double LEARNING_RATE1; // швидкість навчання 
        double MOMENTUM; // коефіцієнт для навчання
        double MIN_ERROR; // мінімальна похибка для навчання
        double[] output = new double[1];

        // Параметри LVQ
        double MIN_ERROR2; // мінімальна похибка для навчання (LVQ)
        double LEARNING_RATE2; // швидкість навчання
        double DECAY_RATE; // швидкість зміни швидкості нвчання

        // масиви параметрів та відповідей
        double[][] inputs;
        double[][] answers;

        // Випадкова тестова вибірка
        double[][] testArray;

        // мережа BackPropagation
        BackPropagationNetwork bpn = null;

        // мережа LVQ
        LVQ lvq = null;

        public Form1()
        {
            InitializeComponent();
         
            this.RandomResults.DataSource = ResultTestBackPropagation;
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        // завантаження даних з бд для навчання мереж
        private void DownloadFromDB_Click(object sender, EventArgs e)
        {
            try
            {
                //  під'єднання до бд
                string connstring = "Server=127.0.0.1;Port=5432;User Id=postgres;Password=1postgres;Database=Labs;";
                NpgsqlConnection conn = new NpgsqlConnection(connstring);
                conn.Open();
                string sql = "SELECT * FROM train ORDER BY id";
                string sql1 = "SELECT DISTINCT Type FROM train ORDER BY Type";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];

                da = new NpgsqlDataAdapter(sql1, conn);
                da.Fill(ds2);
                dt2 = ds2.Tables[0];
                conn.Close();

                TRAINING_PATTERNS = dt.Rows.Count;
                PARAMETERS = dt.Columns.Count - 2;
                NUM_OF_CLUSTERS = dt2.Rows.Count;

                inputs = new double[TRAINING_PATTERNS][];
                answers = new double[TRAINING_PATTERNS][];

                for (int i = 0; i < TRAINING_PATTERNS; i++)
                {
                    inputs[i] = new double[PARAMETERS];
                    answers[i] = new double[1];
                }

                // зчитування параметрів
                for (int i = 0; i < TRAINING_PATTERNS; i++)
                {
                    for (int k = 1; k < dt.Columns.Count - 1; k++)
                        inputs[i][k - 1] = Convert.ToDouble(dt.Rows[i][k]);

                    answers[i][0] = Convert.ToDouble(dt.Rows[i][dt.Columns.Count - 1]);
                }

                ParametersNames = new string[PARAMETERS];

                for(int i = 1; i < dt.Columns.Count - 1; i++)
                {
                    ParametersNames[i-1] = dt.Columns[i].ColumnName;

                }

                Normalize.NormalizeParameters(inputs); // нормалізація параметрів
                MessageBox.Show("Дані для навчання мережі завантажено");
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
                throw;
            }

        }

        // завантаження мережі BackPropagation з файлу
        private void DownloadBackProp_Click(object sender, EventArgs e)
        {
            string filepath = ""; // шлях до файлу, який треба відкрити
            openFileDialog.Multiselect = false;
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filepath = openFileDialog.FileName;
            }

            bpn = new BackPropagationNetwork(filepath);
            MessageBox.Show("Мережа BackPropagation завантажена");
        }

        // завантаження мережі LVQ з файлу
        private void DownLoadLVQ_Click(object sender, EventArgs e)
        {
            string filepath = ""; // шлях до файлу, який треба відкрити
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filepath = openFileDialog.FileName;
            }

            lvq = new LVQ(filepath);
            MessageBox.Show("Мережа LVQ завантажена");
        }

        // збереження мережі BackPropagation у файл
        private void SaveNetwork_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
        }

        // виклик діалогу для збереження мережі BackPropagation у файл
        private void saveFileBackProp_FileOk(object sender, CancelEventArgs e)
        {
            string filepath = saveFileDialog.FileName;
            bpn.Save(filepath);
            MessageBox.Show("Мережа BackPropagation збережена");
        }

        // збереження мережі LVQ у файл
        private void SaveLVQ_Click(object sender, EventArgs e)
        {
            saveFileDialog2.ShowDialog();
        }

        // виклик діалогу для збереження мережі LVQ у файл
        private void saveFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            string filepath = saveFileDialog2.FileName;
            lvq.Save(filepath);
            MessageBox.Show("Мережа LVQ збережена");       
        }

        // генерування тестових даних
        private void GenerateRandom_Click(object sender, EventArgs e)
        {
            TestAmount = Convert.ToInt32(this.testAmountText.Text); 
            testArray = GenerateTest.GenerateOutputICG(PARAMETERS, TestAmount); // створення тестової вибірки
            Normalize.NormalizeTest(testArray); // нормалізація тестової вибірки
            MessageBox.Show("Тестова випадкова вибірка згенерована");
        }

        // вихід із програми
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // створення мережі BackPropagation
        private void CreateBackProp_Click(object sender, EventArgs e)
        {
            int hidden = Convert.ToInt32(this.Hidden_Neurons.Text); // кількість нейронів у прихованому шарі
            layerSizes = new int[3]{ PARAMETERS, hidden, 1 }; // кількість шарів та нейронів у шарах

            LEARNING_RATE1 = Convert.ToDouble(this.Learning_rate1.Text);
            MOMENTUM = Convert.ToDouble(this.Momentum.Text);
            MIN_ERROR = Convert.ToDouble(this.MinError1.Text);

            bpn = new BackPropagationNetwork(layerSizes, TFuncs);
            MessageBox.Show("Мережу BackPropagation створено");
        }

        // Навчання мережі BackPropagation
        private void Train_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            sWatch.Reset();
            sWatch.Start();
            bpn.TrainNetwork(inputs, Normalize.FormAnswersBackPropagation(answers), MIN_ERROR, LEARNING_RATE1, MOMENTUM);
            sWatch.Stop();
            Cursor.Current = Cursors.Arrow;

            tSpan = sWatch.Elapsed;
            this.Time1.Text = Convert.ToString(tSpan);
            MessageBox.Show("Мережа BackPropagation навчена");
        }

        // Створення та навчання мережі LVQ
        private void TrainLVQ_Click(object sender, EventArgs e)
        {
            LEARNING_RATE2 = Convert.ToDouble(LearningRateLVQ.Text);
            MIN_ERROR2 = Convert.ToDouble(MinErrorLVQ.Text);
            DECAY_RATE = Convert.ToDouble(DecayRateLVQ.Text);
            Cursor.Current = Cursors.WaitCursor;
            sWatch2.Reset();
            sWatch2.Start();
            lvq = new LVQ(inputs, Normalize.FormAnswersLVQ(answers), MIN_ERROR2, LEARNING_RATE2, DECAY_RATE, NUM_OF_CLUSTERS);
            sWatch2.Stop();
            Cursor.Current = Cursors.Arrow;

            tSpan = sWatch2.Elapsed;
            this.TimeLVQ.Text = Convert.ToString(tSpan);
            MessageBox.Show("Мережа LVQ створена та навчена");

        }

        // Тестування навчальної вибірки (BackPropagation)
        private void TestTrain_Click(object sender, EventArgs e)
        {
            if (bpn == null)
                MessageBox.Show("Спочатку створіть мережу або завантажте її із файла");
            else
            {
                ResultTrainBackPropagation = new DataTable();
                this.TrainResults.DataSource = ResultTrainBackPropagation;

                // Створення колонок
                ResultTrainBackPropagation.Columns.Add("id");
                for (int i = 0; i < PARAMETERS; i++)
                {
                    ResultTrainBackPropagation.Columns.Add(ParametersNames[i]);
                }

                ResultTrainBackPropagation.Columns.Add("Кластер");

                for (int i = 0; i < TRAINING_PATTERNS; i++)
                {
                    DataRow row = ResultTrainBackPropagation.NewRow();
                    row[0] = i + 1;
                    for (int k = 0; k < PARAMETERS; k++)
                    {
                        row[k + 1] = inputs[i][k];
                    }
                    row["Кластер"] = bpn.getCluster(inputs[i], output);
                    ResultTrainBackPropagation.Rows.Add(row);
                }
                
            }

        }

        // Тестування навчальної вибірки (LVQ)
        private void TestTrainLVQ_Click(object sender, EventArgs e)
        {
            if (lvq == null)
                MessageBox.Show("Спочатку створіть мережу або завантажте її із файла");
            else
            {
                ResultTrainLVQ = new DataTable();
                this.TrainResultsLVQ.DataSource = ResultTrainLVQ;

                // Створення колонок
                ResultTrainLVQ.Columns.Add("id");
                for (int i = 0; i < PARAMETERS; i++)
                {
                    ResultTrainLVQ.Columns.Add(ParametersNames[i]);
                }

                ResultTrainLVQ.Columns.Add("Кластер");

                for (int i = 0; i < TRAINING_PATTERNS; i++)
                {
                    DataRow row = ResultTrainLVQ.NewRow();
                    row[0] = i + 1;
                    for (int k = 0; k < PARAMETERS; k++)
                    {
                        row[k + 1] = inputs[i][k];
                    }
                    row["Кластер"] = lvq.getCluster(inputs[i]);
                    ResultTrainLVQ.Rows.Add(row);
                }

            }

        }

        // Тестування випадкової вибірки (BackPropagation)
        private void TestRandom_Click(object sender, EventArgs e)
        {
            if (bpn == null)
                MessageBox.Show("Спочатку створіть мережу або завантажте її із файла");
            else
            {
                ResultTestBackPropagation = new DataTable();
                this.RandomResults.DataSource = ResultTestBackPropagation;

                // Створення колонок
                ResultTestBackPropagation.Columns.Add("id");
                for (int i = 0; i < PARAMETERS; i++)
                {
                    ResultTestBackPropagation.Columns.Add(ParametersNames[i]);
                }

                ResultTestBackPropagation.Columns.Add("Кластер");

                for (int i = 0; i < TestAmount; i++)
                {
                    DataRow row = ResultTestBackPropagation.NewRow();
                    row[0] = i + 1;
                    for (int k = 0; k < PARAMETERS; k++)
                    {
                        row[k + 1] = testArray[i][k];
                    }
                    row["Кластер"] = bpn.getCluster(testArray[i], output);
                    ResultTestBackPropagation.Rows.Add(row);
                }
            }
        }

        // Тестування випадкової вибірки (LVQ)
        private void TestGeneratedLVQ_Click(object sender, EventArgs e)
        {
            if (lvq == null)
                MessageBox.Show("Спочатку створіть мережу або завантажте її із файла");
            else
            {
                ResultTestLVQ = new DataTable();
                this.GeneratedResultsLVQ.DataSource = ResultTestLVQ;

                // Створення колонок
                ResultTestLVQ.Columns.Add("id");
                for (int i = 0; i < PARAMETERS; i++)
                {
                    ResultTestLVQ.Columns.Add(ParametersNames[i]);
                }

                ResultTestLVQ.Columns.Add("Кластер");

                for (int i = 0; i < TestAmount; i++)
                {
                    DataRow row = ResultTestLVQ.NewRow();
                    row[0] = i + 1;
                    for (int k = 0; k < PARAMETERS; k++)
                    {
                        row[k + 1] = testArray[i][k];
                    }
                    row["Кластер"] = lvq.getCluster(testArray[i]);
                    ResultTestLVQ.Rows.Add(row);
                }
            }
        }

        // Запис результатів для навчальної вибірки (BackPropagation)
        private void SaveTrain_Click(object sender, EventArgs e)
        {
            saveResultsFileDialog.ShowDialog();
        }

        // виклик діалогу для збереження результатів у файл (TrainResults, BackPropagation)
        private void saveResultsFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                string filepath = saveResultsFileDialog.FileName;
                string text = "ID".PadRight(10);
                for(int i = 0; i < ParametersNames.Length; i++)
                {
                    text += ParametersNames[i].PadRight(10);
                }
                text += "Кластер".PadRight(10);
                text += Environment.NewLine;
                foreach (DataGridViewRow row in TrainResults.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        text += cell.Value.ToString().PadRight(10);
                       
                    }
                    text += Environment.NewLine + Environment.NewLine;
                }
                File.AppendAllText(filepath, text);
                MessageBox.Show("Результати навчальної вибірки збережено");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // Запис результатів для навчальної вибірки (LVQ)
        private void SaveTrainLVQ_Click(object sender, EventArgs e)
        {
            saveFileDialog3.ShowDialog();
        }

        // виклик діалогу для збереження результатів у файл (TrainResults, LVQ)
        private void saveFileDialog3_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                string filepath = saveFileDialog3.FileName;
                string text = "ID".PadRight(10);
                for (int i = 0; i < ParametersNames.Length; i++)
                {
                    text += ParametersNames[i].PadRight(10);
                }
                text += "Кластер".PadRight(10);
                text += Environment.NewLine;
                foreach (DataGridViewRow row in TrainResultsLVQ.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        text += cell.Value.ToString().PadRight(10);

                    }
                    text += Environment.NewLine + Environment.NewLine;
                }
                File.AppendAllText(filepath, text);
                MessageBox.Show("Результати навчальної вибірки збережено");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // Запис результатів для випадкової вибірки (BackPropagation)
        private void SaveRandom_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        // виклик діалогу для збереження результатів у файл (RandomResults, BackPropagation)
        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                string filepath = saveFileDialog1.FileName;
                string text = "ID".PadRight(24);
                for (int i = 0; i < ParametersNames.Length; i++)
                {
                    text += ParametersNames[i].PadRight(24);
                }
                text += "Кластер".PadRight(10);
                text += Environment.NewLine;
                foreach (DataGridViewRow row in RandomResults.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        text += cell.Value.ToString().PadRight(24);

                    }
                    text += Environment.NewLine + Environment.NewLine;
                }
                File.AppendAllText(filepath, text);
                MessageBox.Show("Результати випадкової вибірки збережено");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // Запис результатів для випадкової вибірки (LVQ)
        private void SaveGeneratedLVQ_Click(object sender, EventArgs e)
        {
            saveFileDialog4.ShowDialog();
        }

        // виклик діалогу для збереження результатів у файл (GeneratedResults, LVQ)
        private void saveFileDialog4_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                string filepath = saveFileDialog4.FileName;
                string text = "ID".PadRight(24);
                for (int i = 0; i < ParametersNames.Length; i++)
                {
                    text += ParametersNames[i].PadRight(24);
                }
                text += "Кластер".PadRight(10);
                text += Environment.NewLine;
                foreach (DataGridViewRow row in GeneratedResultsLVQ.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        text += cell.Value.ToString().PadRight(24);

                    }
                    text += Environment.NewLine + Environment.NewLine;
                }
                File.AppendAllText(filepath, text);
                MessageBox.Show("Результати випадкової вибірки збережено");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        
    }
}
