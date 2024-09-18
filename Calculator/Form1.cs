﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculadora : Form
    {
        private Operacao OperacaoSelecionada { get; set; }
        private decimal Resultado { get; set; }
        private decimal Valor { get; set; }


        enum Operacao
        {
            Null,
            Adicao,
            Subtracao,
            Multiplicacao,
            Divisao
        }
        public Calculadora()
        {
            InitializeComponent();
        }


        private void btnZero_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";

        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";

        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";

        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";

        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";

        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";

        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";

        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";

        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";

        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";

        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Divisao;
            Valor = Convert.ToDecimal(txtResultado.Text);

            txtResultado.Text = "";
            lblOperacao.Text = "/";

        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Multiplicacao;
            Valor = Convert.ToDecimal(txtResultado.Text);

            txtResultado.Text = "";
            lblOperacao.Text = "*";

        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Subtracao;
            Valor = Convert.ToDecimal(txtResultado.Text);

            txtResultado.Text = "";
            lblOperacao.Text = "-";


        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Adicao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            lblOperacao.Text = "+";

        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            switch (OperacaoSelecionada)
            {
                case Operacao.Adicao:
                    Resultado = Valor + Convert.ToDecimal(txtResultado.Text);
                    break;
                case Operacao.Subtracao:
                    Resultado = Valor - Convert.ToDecimal(txtResultado.Text);
                    break;
                case Operacao.Multiplicacao:
                    Resultado = Valor * Convert.ToDecimal(txtResultado.Text);
                    break;
                case Operacao.Divisao:
                    Resultado = Valor / Convert.ToDecimal(txtResultado.Text);
                    break;
            }
            txtResultado.Text = Convert.ToString(Resultado);
            lblOperacao.Text = "=";

        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if(!txtResultado.Text.Contains(","))
                txtResultado.Text += ",";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = ""; 
            lblOperacao.Text = "";
            Valor = 0;
            Resultado = 0;
            OperacaoSelecionada = Operacao.Null;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblOperacao_Click(object sender, EventArgs e)
        {

        }
    }
}