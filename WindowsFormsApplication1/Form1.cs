using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

         public string nome;
         public string email;
         public string tel;
         public string CEP;
         public string end;
         public string prof;
         public string salario;
         public string idade;
         public string sexo;
         public string Nfilhos;
         public string TS;
         public string EC;

         string lines = "ERICK";
         

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void nomesf_TextChanged(object sender, EventArgs e)
        {
            nome = nomesf.Text;
        }

        private void emailf_TextChanged(object sender, EventArgs e)
        {
            email = e_mail.Text;
        }

        private void salvar1(object sender, EventArgs e)
        {
            if(infos() != null){
            listaF.Items.Add(nome);
           
            
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\lista\WriteLines2.txt", true))
            {
                file.WriteLine(infos());
            }

            }

            else MessageBox.Show("Algo Não foi preenchido");
        }

        private void tel_TextChanged(object sender, EventArgs e)
        {
            tel = tell.Text;
        }

        private void CEP_TextChanged(object sender, EventArgs e)
        {
            CEP = CepT.Text;
        }

        private void Rua_TextChanged(object sender, EventArgs e)
        {
            end = Rua.Text;
        }

        private void sala_TextChanged(object sender, EventArgs e)
        {
            salario = sala.Text;
        }

        private void profissao_TextChanged(object sender, EventArgs e)
        {
            prof = profissao.Text;
        }

        private void listaF_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void CBid_SelectedIndexChanged(object sender, EventArgs e)
        {
            idade = CBid.Text;
        }

        private void SexoF_SelectedIndexChanged(object sender, EventArgs e)
        {
            sexo = SexoF.Text;
        }

        private void filhos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Nfilhos = filhos.Text;
        }

        private void tipoSangue_SelectedIndexChanged(object sender, EventArgs e)
        {
            TS = tipoSangue.Text;
        }

        private void estadoCivil_SelectedIndexChanged(object sender, EventArgs e)
        {
            EC = estadoCivil.Text;
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            nomesf.Text = null;
            tell.Text = null;
            CepT.Text = null;
            Rua.Text = null;
            sala.Text = null;
            profissao.Text = null;
            CBid.Text = null;
            CBid.SelectedIndex = -1;
            SexoF.Text = null;
            SexoF.SelectedIndex = -1;
            filhos.Text = null;
            filhos.SelectedIndex = -1;
            tipoSangue.Text = null;
            tipoSangue.SelectedIndex = -1;
            estadoCivil.Text = null;
            estadoCivil.SelectedIndex = -1;
            e_mail.Text = null;
        }

        string infos() {
            if (nome == null || email == null || tel == null || CEP == null || end == null || salario == null || prof == null ||
                idade == null || sexo == null || Nfilhos == null || TS == null || EC == null) {
                return null; }

            return "Nome: " + nome + " || E-mail: " + email + " || Tel: " + tel + " || CEP: " + CEP + " || Endereço: " + end + 
                " || Salário: " + salario + " reais || Profissão: " + prof + " || Idade: " 
                + idade + " anos || Sexo: " + sexo + " || N° de filhos: " + Nfilhos + " filhos || Tipo Sanguineo: " + TS + 
                " || estado Civil: " + EC;
            
            

       }

        private void Remove_Click(object sender, EventArgs e)
        {
            listaF.Items.Remove(listaF.Text);
            listaF.Text = null;
            
        }


    }


}
