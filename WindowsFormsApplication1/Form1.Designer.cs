namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SexoF = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tipoSangue = new System.Windows.Forms.ComboBox();
            this.CBid = new System.Windows.Forms.ComboBox();
            this.filhos = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.profissao = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.sala = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.estadoCivil = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tell = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.e_mail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.CepT = new System.Windows.Forms.TextBox();
            this.Remove = new System.Windows.Forms.Button();
            this.listaF = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.Restart = new System.Windows.Forms.Button();
            this.nomesf = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Rua = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Idade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sexo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "N° de Filhos:";
            // 
            // SexoF
            // 
            this.SexoF.FormattingEnabled = true;
            this.SexoF.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.SexoF.Location = new System.Drawing.Point(153, 50);
            this.SexoF.Name = "SexoF";
            this.SexoF.Size = new System.Drawing.Size(101, 21);
            this.SexoF.TabIndex = 10;
            this.SexoF.SelectedIndexChanged += new System.EventHandler(this.SexoF_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tipo Sanguineo:";
            // 
            // tipoSangue
            // 
            this.tipoSangue.FormattingEnabled = true;
            this.tipoSangue.Items.AddRange(new object[] {
            "A+",
            "A-",
            "AB+",
            "AB-",
            "B+",
            "B-",
            "O+",
            "O-"});
            this.tipoSangue.Location = new System.Drawing.Point(108, 78);
            this.tipoSangue.Name = "tipoSangue";
            this.tipoSangue.Size = new System.Drawing.Size(43, 21);
            this.tipoSangue.TabIndex = 12;
            this.tipoSangue.SelectedIndexChanged += new System.EventHandler(this.tipoSangue_SelectedIndexChanged);
            // 
            // CBid
            // 
            this.CBid.FormattingEnabled = true;
            this.CBid.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70"});
            this.CBid.Location = new System.Drawing.Point(65, 51);
            this.CBid.Name = "CBid";
            this.CBid.Size = new System.Drawing.Size(43, 21);
            this.CBid.TabIndex = 13;
            this.CBid.SelectedIndexChanged += new System.EventHandler(this.CBid_SelectedIndexChanged);
            // 
            // filhos
            // 
            this.filhos.FormattingEnabled = true;
            this.filhos.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50"});
            this.filhos.Location = new System.Drawing.Point(330, 51);
            this.filhos.Name = "filhos";
            this.filhos.Size = new System.Drawing.Size(43, 21);
            this.filhos.TabIndex = 14;
            this.filhos.SelectedIndexChanged += new System.EventHandler(this.filhos_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(156, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Profissão:";
            // 
            // profissao
            // 
            this.profissao.Location = new System.Drawing.Point(206, 172);
            this.profissao.Name = "profissao";
            this.profissao.Size = new System.Drawing.Size(167, 20);
            this.profissao.TabIndex = 16;
            this.profissao.TextChanged += new System.EventHandler(this.profissao_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Salario:";
            // 
            // sala
            // 
            this.sala.Location = new System.Drawing.Point(65, 172);
            this.sala.Name = "sala";
            this.sala.Size = new System.Drawing.Size(88, 20);
            this.sala.TabIndex = 18;
            this.sala.TextChanged += new System.EventHandler(this.sala_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(168, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "estado Civil:";
            // 
            // estadoCivil
            // 
            this.estadoCivil.FormattingEnabled = true;
            this.estadoCivil.Items.AddRange(new object[] {
            "Casado(a)",
            "Solteiro(a)",
            "Viuvo(a)",
            "Noivo(a)"});
            this.estadoCivil.Location = new System.Drawing.Point(231, 81);
            this.estadoCivil.Name = "estadoCivil";
            this.estadoCivil.Size = new System.Drawing.Size(142, 21);
            this.estadoCivil.TabIndex = 20;
            this.estadoCivil.SelectedIndexChanged += new System.EventHandler(this.estadoCivil_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Telefone:";
            // 
            // tell
            // 
            this.tell.Location = new System.Drawing.Point(77, 111);
            this.tell.Name = "tell";
            this.tell.Size = new System.Drawing.Size(82, 20);
            this.tell.TabIndex = 22;
            this.tell.TextChanged += new System.EventHandler(this.tel_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(170, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "E-mail:";
            // 
            // e_mail
            // 
            this.e_mail.Location = new System.Drawing.Point(206, 111);
            this.e_mail.Name = "e_mail";
            this.e_mail.Size = new System.Drawing.Size(167, 20);
            this.e_mail.TabIndex = 24;
            this.e_mail.TextChanged += new System.EventHandler(this.emailf_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 145);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "CEP:";
            // 
            // CepT
            // 
            this.CepT.Location = new System.Drawing.Point(59, 142);
            this.CepT.Name = "CepT";
            this.CepT.Size = new System.Drawing.Size(115, 20);
            this.CepT.TabIndex = 26;
            this.CepT.TextChanged += new System.EventHandler(this.CEP_TextChanged);
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(412, 200);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(113, 23);
            this.Remove.TabIndex = 28;
            this.Remove.Text = "Remover";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // listaF
            // 
            this.listaF.FormattingEnabled = true;
            this.listaF.Location = new System.Drawing.Point(379, 42);
            this.listaF.Name = "listaF";
            this.listaF.Size = new System.Drawing.Size(153, 21);
            this.listaF.TabIndex = 29;
            this.listaF.SelectedIndexChanged += new System.EventHandler(this.listaF_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(379, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(155, 16);
            this.label12.TabIndex = 30;
            this.label12.Text = "Lista de funcionarios:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(260, 200);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 23);
            this.button3.TabIndex = 31;
            this.button3.Text = "Salvar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.salvar1);
            // 
            // Restart
            // 
            this.Restart.Location = new System.Drawing.Point(141, 200);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(113, 23);
            this.Restart.TabIndex = 32;
            this.Restart.Text = "Reset";
            this.Restart.UseVisualStyleBackColor = true;
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // nomesf
            // 
            this.nomesf.Location = new System.Drawing.Point(65, 16);
            this.nomesf.Name = "nomesf";
            this.nomesf.Size = new System.Drawing.Size(308, 20);
            this.nomesf.TabIndex = 33;
            this.nomesf.TextChanged += new System.EventHandler(this.nomesf_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(178, 145);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 13);
            this.label13.TabIndex = 34;
            this.label13.Text = "Rua e N°:";
            // 
            // Rua
            // 
            this.Rua.Location = new System.Drawing.Point(231, 142);
            this.Rua.Name = "Rua";
            this.Rua.Size = new System.Drawing.Size(142, 20);
            this.Rua.TabIndex = 35;
            this.Rua.TextChanged += new System.EventHandler(this.Rua_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 235);
            this.Controls.Add(this.Rua);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.nomesf);
            this.Controls.Add(this.Restart);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.listaF);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.CepT);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.e_mail);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tell);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.estadoCivil);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.sala);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.profissao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.filhos);
            this.Controls.Add(this.CBid);
            this.Controls.Add(this.tipoSangue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SexoF);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Formulario de Trabalho";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox SexoF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox tipoSangue;
        private System.Windows.Forms.ComboBox CBid;
        private System.Windows.Forms.ComboBox filhos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox profissao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox sala;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox estadoCivil;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tell;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox e_mail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox CepT;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.ComboBox listaF;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Restart;
        private System.Windows.Forms.TextBox nomesf;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Rua;


    }
}

