using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MinhaAgenda.dao;
using MinhaAgenda.model;
using MinhaAgenda.view;

namespace MinhaAgenda
{
    public partial class AgendaFrm : Form
    {
        public AgendaFrm()
        {
            InitializeComponent();
        }

        private void adicionarBtn_MouseEnter(object sender, EventArgs e)
        {
            informacaoLbl.Text = "Adicione contatos a sua agenda";
            informacaoLbl.Visible = true;
        }

        private void adicionarBtn_MouseLeave(object sender, EventArgs e)
        {
            informacaoLbl.Text = "";
            informacaoLbl.Visible = false;
        }

        private void removerBtn_MouseEnter(object sender, EventArgs e)
        {
            informacaoLbl.Text = "Remova contatos da sua agenda";
            informacaoLbl.Visible = true;
        }

        private void removerBtn_MouseLeave(object sender, EventArgs e)
        {
            informacaoLbl.Text = "";
            informacaoLbl.Visible = false;
           
        }

        private void editarBtn_MouseEnter(object sender, EventArgs e)
        {
            informacaoLbl.Text = "Edite o contato que desejar";
            informacaoLbl.Visible = true;
        }

        private void editarBtn_MouseLeave(object sender, EventArgs e)
        {
            informacaoLbl.Text = "";
            informacaoLbl.Visible = false;
        }

        private void pesquisarBtn_MouseEnter(object sender, EventArgs e)
        {
            informacaoLbl.Text = "Pesquise contatos por id ou pelo nome";
            informacaoLbl.Visible = true;
        }

        private void pesquisarBtn_MouseLeave(object sender, EventArgs e)
        {
            informacaoLbl.Text = "";
            informacaoLbl.Visible = false;
        }

        private void pesquisarBtn_Click(object sender, EventArgs e)
        {
            PesquisarForm pesquisar = new PesquisarForm();
            pesquisar.Show();
        }

        private void adicionarBtn_Click(object sender, EventArgs e)
        {
            AdicionarFrm adicionarForm = new AdicionarFrm();
            adicionarForm.Show();
        }

        private void buscarTodosBtn_Click(object sender, EventArgs e)
        { 
            Resultados resultado = new Resultados();
            resultado.Show();
        }
    }
}
