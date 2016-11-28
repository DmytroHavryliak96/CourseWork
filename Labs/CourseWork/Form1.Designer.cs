namespace CourseWork
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.Time1 = new System.Windows.Forms.TextBox();
            this.Train = new System.Windows.Forms.Button();
            this.SaveNetwork = new System.Windows.Forms.Button();
            this.SaveRandom = new System.Windows.Forms.Button();
            this.SaveTrain = new System.Windows.Forms.Button();
            this.TrainResults = new System.Windows.Forms.DataGridView();
            this.RandomResults = new System.Windows.Forms.DataGridView();
            this.TestRandom = new System.Windows.Forms.Button();
            this.TestTrain = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MinError1 = new System.Windows.Forms.TextBox();
            this.Momentum = new System.Windows.Forms.TextBox();
            this.Learning_rate1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Hidden_Neurons = new System.Windows.Forms.TextBox();
            this.CreateBackProp = new System.Windows.Forms.Button();
            this.DownloadBackProp = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.SaveGeneratedLVQ = new System.Windows.Forms.Button();
            this.SaveTrainLVQ = new System.Windows.Forms.Button();
            this.TrainResultsLVQ = new System.Windows.Forms.DataGridView();
            this.GeneratedResultsLVQ = new System.Windows.Forms.DataGridView();
            this.TestGeneratedLVQ = new System.Windows.Forms.Button();
            this.TestTrainLVQ = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.DecayRateLVQ = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.MinErrorLVQ = new System.Windows.Forms.TextBox();
            this.LearningRateLVQ = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TimeLVQ = new System.Windows.Forms.TextBox();
            this.TrainLVQ = new System.Windows.Forms.Button();
            this.SaveLVQ = new System.Windows.Forms.Button();
            this.DownLoadLVQ = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.testAmountText = new System.Windows.Forms.TextBox();
            this.DownloadFromDB = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.GenerateRandom = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.saveResultsFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog3 = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog4 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrainResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RandomResults)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrainResultsLVQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeneratedResultsLVQ)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 47);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(851, 475);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.Time1);
            this.tabPage1.Controls.Add(this.Train);
            this.tabPage1.Controls.Add(this.SaveNetwork);
            this.tabPage1.Controls.Add(this.SaveRandom);
            this.tabPage1.Controls.Add(this.SaveTrain);
            this.tabPage1.Controls.Add(this.TrainResults);
            this.tabPage1.Controls.Add(this.RandomResults);
            this.tabPage1.Controls.Add(this.TestRandom);
            this.tabPage1.Controls.Add(this.TestTrain);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.MinError1);
            this.tabPage1.Controls.Add(this.Momentum);
            this.tabPage1.Controls.Add(this.Learning_rate1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.Hidden_Neurons);
            this.tabPage1.Controls.Add(this.CreateBackProp);
            this.tabPage1.Controls.Add(this.DownloadBackProp);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(843, 449);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Мережа BackPropagation";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(53, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 15);
            this.label9.TabIndex = 24;
            this.label9.Text = "Час навчання мережі";
            // 
            // Time1
            // 
            this.Time1.Location = new System.Drawing.Point(56, 138);
            this.Time1.Name = "Time1";
            this.Time1.ReadOnly = true;
            this.Time1.Size = new System.Drawing.Size(110, 20);
            this.Time1.TabIndex = 23;
            // 
            // Train
            // 
            this.Train.Location = new System.Drawing.Point(21, 77);
            this.Train.Name = "Train";
            this.Train.Size = new System.Drawing.Size(176, 21);
            this.Train.TabIndex = 22;
            this.Train.Text = "Навчити мережу";
            this.Train.UseVisualStyleBackColor = true;
            this.Train.Click += new System.EventHandler(this.Train_Click);
            // 
            // SaveNetwork
            // 
            this.SaveNetwork.Location = new System.Drawing.Point(21, 42);
            this.SaveNetwork.Name = "SaveNetwork";
            this.SaveNetwork.Size = new System.Drawing.Size(176, 23);
            this.SaveNetwork.TabIndex = 21;
            this.SaveNetwork.Text = "Зберегти мережу у файл";
            this.SaveNetwork.UseVisualStyleBackColor = true;
            this.SaveNetwork.Click += new System.EventHandler(this.SaveNetwork_Click);
            // 
            // SaveRandom
            // 
            this.SaveRandom.Location = new System.Drawing.Point(417, 389);
            this.SaveRandom.Name = "SaveRandom";
            this.SaveRandom.Size = new System.Drawing.Size(176, 37);
            this.SaveRandom.TabIndex = 20;
            this.SaveRandom.Text = "Зберегти результати для випадкової вибірки";
            this.SaveRandom.UseVisualStyleBackColor = true;
            this.SaveRandom.Click += new System.EventHandler(this.SaveRandom_Click);
            // 
            // SaveTrain
            // 
            this.SaveTrain.Location = new System.Drawing.Point(21, 389);
            this.SaveTrain.Name = "SaveTrain";
            this.SaveTrain.Size = new System.Drawing.Size(176, 37);
            this.SaveTrain.TabIndex = 19;
            this.SaveTrain.Text = "Зберегти результати для навч. вибірки";
            this.SaveTrain.UseVisualStyleBackColor = true;
            this.SaveTrain.Click += new System.EventHandler(this.SaveTrain_Click);
            // 
            // TrainResults
            // 
            this.TrainResults.AllowUserToAddRows = false;
            this.TrainResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TrainResults.Location = new System.Drawing.Point(21, 226);
            this.TrainResults.Name = "TrainResults";
            this.TrainResults.Size = new System.Drawing.Size(347, 157);
            this.TrainResults.TabIndex = 18;
            // 
            // RandomResults
            // 
            this.RandomResults.AllowUserToAddRows = false;
            this.RandomResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RandomResults.Location = new System.Drawing.Point(417, 226);
            this.RandomResults.Name = "RandomResults";
            this.RandomResults.Size = new System.Drawing.Size(391, 157);
            this.RandomResults.TabIndex = 15;
            // 
            // TestRandom
            // 
            this.TestRandom.Location = new System.Drawing.Point(417, 183);
            this.TestRandom.Name = "TestRandom";
            this.TestRandom.Size = new System.Drawing.Size(144, 37);
            this.TestRandom.TabIndex = 14;
            this.TestRandom.Text = "Провести тест на випадкових даних";
            this.TestRandom.UseVisualStyleBackColor = true;
            this.TestRandom.Click += new System.EventHandler(this.TestRandom_Click);
            // 
            // TestTrain
            // 
            this.TestTrain.Location = new System.Drawing.Point(21, 183);
            this.TestTrain.Name = "TestTrain";
            this.TestTrain.Size = new System.Drawing.Size(176, 37);
            this.TestTrain.TabIndex = 13;
            this.TestTrain.Text = "Протестувати навчальну вибірку";
            this.TestTrain.UseVisualStyleBackColor = true;
            this.TestTrain.Click += new System.EventHandler(this.TestTrain_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(268, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(540, 1);
            this.label7.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(632, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Введіть мінімальну похибку";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(632, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Введіть коефіцієнт Momentum";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(632, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "Введіть швидкість навчання мережі";
            // 
            // MinError1
            // 
            this.MinError1.Location = new System.Drawing.Point(503, 112);
            this.MinError1.Name = "MinError1";
            this.MinError1.Size = new System.Drawing.Size(100, 20);
            this.MinError1.TabIndex = 8;
            // 
            // Momentum
            // 
            this.Momentum.Location = new System.Drawing.Point(503, 70);
            this.Momentum.Name = "Momentum";
            this.Momentum.Size = new System.Drawing.Size(100, 20);
            this.Momentum.TabIndex = 7;
            // 
            // Learning_rate1
            // 
            this.Learning_rate1.Location = new System.Drawing.Point(503, 26);
            this.Learning_rate1.Name = "Learning_rate1";
            this.Learning_rate1.Size = new System.Drawing.Size(100, 20);
            this.Learning_rate1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(265, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Введіть кількість нейронів у прихованому шарі";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(235, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1, 147);
            this.label2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 1);
            this.label1.TabIndex = 3;
            // 
            // Hidden_Neurons
            // 
            this.Hidden_Neurons.Location = new System.Drawing.Point(268, 112);
            this.Hidden_Neurons.Name = "Hidden_Neurons";
            this.Hidden_Neurons.Size = new System.Drawing.Size(100, 20);
            this.Hidden_Neurons.TabIndex = 2;
            // 
            // CreateBackProp
            // 
            this.CreateBackProp.Location = new System.Drawing.Point(268, 26);
            this.CreateBackProp.Name = "CreateBackProp";
            this.CreateBackProp.Size = new System.Drawing.Size(176, 34);
            this.CreateBackProp.TabIndex = 1;
            this.CreateBackProp.Text = "Створити мережу";
            this.CreateBackProp.UseVisualStyleBackColor = true;
            this.CreateBackProp.Click += new System.EventHandler(this.CreateBackProp_Click);
            // 
            // DownloadBackProp
            // 
            this.DownloadBackProp.Location = new System.Drawing.Point(21, 11);
            this.DownloadBackProp.Name = "DownloadBackProp";
            this.DownloadBackProp.Size = new System.Drawing.Size(176, 25);
            this.DownloadBackProp.TabIndex = 0;
            this.DownloadBackProp.Text = "Завантажити мережу з файла";
            this.DownloadBackProp.UseVisualStyleBackColor = true;
            this.DownloadBackProp.Click += new System.EventHandler(this.DownloadBackProp_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.SaveGeneratedLVQ);
            this.tabPage2.Controls.Add(this.SaveTrainLVQ);
            this.tabPage2.Controls.Add(this.TrainResultsLVQ);
            this.tabPage2.Controls.Add(this.GeneratedResultsLVQ);
            this.tabPage2.Controls.Add(this.TestGeneratedLVQ);
            this.tabPage2.Controls.Add(this.TestTrainLVQ);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.DecayRateLVQ);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.MinErrorLVQ);
            this.tabPage2.Controls.Add(this.LearningRateLVQ);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.TimeLVQ);
            this.tabPage2.Controls.Add(this.TrainLVQ);
            this.tabPage2.Controls.Add(this.SaveLVQ);
            this.tabPage2.Controls.Add(this.DownLoadLVQ);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(843, 449);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Мережа Learning Vector Quantization";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // SaveGeneratedLVQ
            // 
            this.SaveGeneratedLVQ.Location = new System.Drawing.Point(417, 397);
            this.SaveGeneratedLVQ.Name = "SaveGeneratedLVQ";
            this.SaveGeneratedLVQ.Size = new System.Drawing.Size(176, 37);
            this.SaveGeneratedLVQ.TabIndex = 41;
            this.SaveGeneratedLVQ.Text = "Зберегти результати для випадкової вибірки";
            this.SaveGeneratedLVQ.UseVisualStyleBackColor = true;
            this.SaveGeneratedLVQ.Click += new System.EventHandler(this.SaveGeneratedLVQ_Click);
            // 
            // SaveTrainLVQ
            // 
            this.SaveTrainLVQ.Location = new System.Drawing.Point(21, 397);
            this.SaveTrainLVQ.Name = "SaveTrainLVQ";
            this.SaveTrainLVQ.Size = new System.Drawing.Size(176, 37);
            this.SaveTrainLVQ.TabIndex = 40;
            this.SaveTrainLVQ.Text = "Зберегти результати для навч. вибірки";
            this.SaveTrainLVQ.UseVisualStyleBackColor = true;
            this.SaveTrainLVQ.Click += new System.EventHandler(this.SaveTrainLVQ_Click);
            // 
            // TrainResultsLVQ
            // 
            this.TrainResultsLVQ.AllowUserToAddRows = false;
            this.TrainResultsLVQ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TrainResultsLVQ.Location = new System.Drawing.Point(21, 225);
            this.TrainResultsLVQ.Name = "TrainResultsLVQ";
            this.TrainResultsLVQ.Size = new System.Drawing.Size(347, 157);
            this.TrainResultsLVQ.TabIndex = 39;
            // 
            // GeneratedResultsLVQ
            // 
            this.GeneratedResultsLVQ.AllowUserToAddRows = false;
            this.GeneratedResultsLVQ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GeneratedResultsLVQ.Location = new System.Drawing.Point(417, 225);
            this.GeneratedResultsLVQ.Name = "GeneratedResultsLVQ";
            this.GeneratedResultsLVQ.Size = new System.Drawing.Size(391, 157);
            this.GeneratedResultsLVQ.TabIndex = 38;
            // 
            // TestGeneratedLVQ
            // 
            this.TestGeneratedLVQ.Location = new System.Drawing.Point(417, 182);
            this.TestGeneratedLVQ.Name = "TestGeneratedLVQ";
            this.TestGeneratedLVQ.Size = new System.Drawing.Size(144, 37);
            this.TestGeneratedLVQ.TabIndex = 37;
            this.TestGeneratedLVQ.Text = "Провести тест на випадкових даних";
            this.TestGeneratedLVQ.UseVisualStyleBackColor = true;
            this.TestGeneratedLVQ.Click += new System.EventHandler(this.TestGeneratedLVQ_Click);
            // 
            // TestTrainLVQ
            // 
            this.TestTrainLVQ.Location = new System.Drawing.Point(21, 182);
            this.TestTrainLVQ.Name = "TestTrainLVQ";
            this.TestTrainLVQ.Size = new System.Drawing.Size(176, 37);
            this.TestTrainLVQ.TabIndex = 36;
            this.TestTrainLVQ.Text = "Протестувати навчальну вибірку";
            this.TestTrainLVQ.UseVisualStyleBackColor = true;
            this.TestTrainLVQ.Click += new System.EventHandler(this.TestTrainLVQ_Click);
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(634, 110);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(176, 34);
            this.label16.TabIndex = 35;
            this.label16.Text = "Введіть швидкість зменшення швидкості навчання";
            // 
            // DecayRateLVQ
            // 
            this.DecayRateLVQ.Location = new System.Drawing.Point(505, 110);
            this.DecayRateLVQ.Name = "DecayRateLVQ";
            this.DecayRateLVQ.Size = new System.Drawing.Size(100, 20);
            this.DecayRateLVQ.TabIndex = 34;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(634, 66);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(176, 20);
            this.label14.TabIndex = 33;
            this.label14.Text = "Введіть мінімальну похибку";
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(634, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(176, 32);
            this.label15.TabIndex = 32;
            this.label15.Text = "Введіть швидкість навчання мережі";
            // 
            // MinErrorLVQ
            // 
            this.MinErrorLVQ.Location = new System.Drawing.Point(505, 66);
            this.MinErrorLVQ.Name = "MinErrorLVQ";
            this.MinErrorLVQ.Size = new System.Drawing.Size(100, 20);
            this.MinErrorLVQ.TabIndex = 31;
            // 
            // LearningRateLVQ
            // 
            this.LearningRateLVQ.Location = new System.Drawing.Point(505, 24);
            this.LearningRateLVQ.Name = "LearningRateLVQ";
            this.LearningRateLVQ.Size = new System.Drawing.Size(100, 20);
            this.LearningRateLVQ.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(268, 164);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(540, 1);
            this.label11.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(235, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(1, 147);
            this.label12.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(6, 164);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(205, 1);
            this.label13.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(307, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 15);
            this.label10.TabIndex = 26;
            this.label10.Text = "Час навчання мережі";
            // 
            // TimeLVQ
            // 
            this.TimeLVQ.Location = new System.Drawing.Point(310, 124);
            this.TimeLVQ.Name = "TimeLVQ";
            this.TimeLVQ.ReadOnly = true;
            this.TimeLVQ.Size = new System.Drawing.Size(110, 20);
            this.TimeLVQ.TabIndex = 25;
            // 
            // TrainLVQ
            // 
            this.TrainLVQ.Location = new System.Drawing.Point(271, 36);
            this.TrainLVQ.Name = "TrainLVQ";
            this.TrainLVQ.Size = new System.Drawing.Size(176, 32);
            this.TrainLVQ.TabIndex = 24;
            this.TrainLVQ.Text = "Створити та навчити мережу";
            this.TrainLVQ.UseVisualStyleBackColor = true;
            this.TrainLVQ.Click += new System.EventHandler(this.TrainLVQ_Click);
            // 
            // SaveLVQ
            // 
            this.SaveLVQ.Location = new System.Drawing.Point(21, 103);
            this.SaveLVQ.Name = "SaveLVQ";
            this.SaveLVQ.Size = new System.Drawing.Size(176, 32);
            this.SaveLVQ.TabIndex = 23;
            this.SaveLVQ.Text = "Зберегти мережу у файл";
            this.SaveLVQ.UseVisualStyleBackColor = true;
            this.SaveLVQ.Click += new System.EventHandler(this.SaveLVQ_Click);
            // 
            // DownLoadLVQ
            // 
            this.DownLoadLVQ.Location = new System.Drawing.Point(21, 36);
            this.DownLoadLVQ.Name = "DownLoadLVQ";
            this.DownLoadLVQ.Size = new System.Drawing.Size(176, 32);
            this.DownLoadLVQ.TabIndex = 0;
            this.DownLoadLVQ.Text = "Завантажити мережу з файла";
            this.DownLoadLVQ.UseVisualStyleBackColor = true;
            this.DownLoadLVQ.Click += new System.EventHandler(this.DownLoadLVQ_Click);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(462, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 28);
            this.label8.TabIndex = 17;
            this.label8.Text = "Введіть кількість випадкових даних";
            // 
            // testAmountText
            // 
            this.testAmountText.Location = new System.Drawing.Point(344, 15);
            this.testAmountText.Name = "testAmountText";
            this.testAmountText.Size = new System.Drawing.Size(100, 20);
            this.testAmountText.TabIndex = 16;
            // 
            // DownloadFromDB
            // 
            this.DownloadFromDB.Location = new System.Drawing.Point(16, 12);
            this.DownloadFromDB.Name = "DownloadFromDB";
            this.DownloadFromDB.Size = new System.Drawing.Size(174, 23);
            this.DownloadFromDB.TabIndex = 1;
            this.DownloadFromDB.Text = "Завантажити дані з бази даних";
            this.DownloadFromDB.UseVisualStyleBackColor = true;
            this.DownloadFromDB.Click += new System.EventHandler(this.DownloadFromDB_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(771, 12);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(88, 23);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Вихід";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // GenerateRandom
            // 
            this.GenerateRandom.Location = new System.Drawing.Point(214, 12);
            this.GenerateRandom.Name = "GenerateRandom";
            this.GenerateRandom.Size = new System.Drawing.Size(114, 23);
            this.GenerateRandom.TabIndex = 4;
            this.GenerateRandom.Text = "Згенерувати тест";
            this.GenerateRandom.UseVisualStyleBackColor = true;
            this.GenerateRandom.Click += new System.EventHandler(this.GenerateRandom_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileBackProp_FileOk);
            // 
            // saveResultsFileDialog
            // 
            this.saveResultsFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveResultsFileDialog_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // saveFileDialog2
            // 
            this.saveFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog2_FileOk);
            // 
            // saveFileDialog3
            // 
            this.saveFileDialog3.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog3_FileOk);
            // 
            // saveFileDialog4
            // 
            this.saveFileDialog4.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog4_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 534);
            this.Controls.Add(this.GenerateRandom);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.DownloadFromDB);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.testAmountText);
            this.Controls.Add(this.label8);
            this.Name = "Form1";
            this.Text = "CourseWork Гавриляка Дмитра";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrainResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RandomResults)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrainResultsLVQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeneratedResultsLVQ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox Hidden_Neurons;
        private System.Windows.Forms.Button CreateBackProp;
        private System.Windows.Forms.Button DownloadBackProp;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button DownLoadLVQ;
        private System.Windows.Forms.Button DownloadFromDB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MinError1;
        private System.Windows.Forms.TextBox Momentum;
        private System.Windows.Forms.TextBox Learning_rate1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button SaveNetwork;
        private System.Windows.Forms.Button SaveRandom;
        private System.Windows.Forms.Button SaveTrain;
        private System.Windows.Forms.DataGridView TrainResults;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox testAmountText;
        private System.Windows.Forms.DataGridView RandomResults;
        private System.Windows.Forms.Button TestRandom;
        private System.Windows.Forms.Button TestTrain;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button GenerateRandom;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Time1;
        private System.Windows.Forms.Button Train;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.SaveFileDialog saveResultsFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button TrainLVQ;
        private System.Windows.Forms.Button SaveLVQ;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox MinErrorLVQ;
        private System.Windows.Forms.TextBox LearningRateLVQ;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TimeLVQ;
        private System.Windows.Forms.Button TestGeneratedLVQ;
        private System.Windows.Forms.Button TestTrainLVQ;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox DecayRateLVQ;
        private System.Windows.Forms.DataGridView TrainResultsLVQ;
        private System.Windows.Forms.DataGridView GeneratedResultsLVQ;
        private System.Windows.Forms.Button SaveGeneratedLVQ;
        private System.Windows.Forms.Button SaveTrainLVQ;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog4;
    }
}

