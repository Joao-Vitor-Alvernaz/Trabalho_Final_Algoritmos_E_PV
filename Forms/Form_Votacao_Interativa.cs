using Atividade_Final.Models;
using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_Final.Forms
{
    public partial class Form_Votacao_Interativa : Form
    {
        List<Candidato> lista_Candidato = new List<Candidato>();
        public Form_Votacao_Interativa()
        {
            InitializeComponent();
            var pasta = new XLWorkbook("C:\\Users\\Vitor\\Desktop\\Programacao\\Atividade_Final\\candidatos.xlsx");
            var plan1 = pasta.Worksheet(1);
            int qtdLinhas = plan1.RowsUsed().Count();
            int linhaLivre = qtdLinhas + 1;

            for (int i = 2; i <= qtdLinhas; i++)
            {
                Candidato candidato = new Candidato();
                candidato.Id = Convert.ToInt32(plan1.Cell(i, 1).Value.ToString());
                candidato.nome = plan1.Cell(i, 3).Value.ToString();
                candidato.apelido = plan1.Cell(i, 4).Value.ToString();
                candidato.partido = plan1.Cell(i, 5).Value.ToString();
                candidato.numero = Convert.ToInt32(plan1.Cell(i, 2).Value.ToString());

                lista_Candidato.Add(candidato);
            }
            foreach (var perfil in lista_Candidato)
            {
                dgvCandidatos.Rows.Add(perfil.numero,
                                        perfil.nome);
            }
        }

        private void btVotar_Click(object sender, EventArgs e)
        {
            var pasta = new XLWorkbook("C:\\Users\\Vitor\\Desktop\\Programacao\\Atividade_Final\\candidatos.xlsx");
            var plan1 = pasta.Worksheet(1);

            foreach (var escolhido in lista_Candidato)
            {
                if(escolhido.numero == Convert.ToInt32(txtNumero.Text))
                {
                    int posicao = escolhido.Id + 1;
                    int qtdVotos = Convert.ToInt32(plan1.Cell(posicao, 6).Value.ToString());
                    plan1.Cell(posicao, 6).Value = qtdVotos + 1;
                    pasta.Save();
                }
            }
        }
    }
}
