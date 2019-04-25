using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App4.Modelos;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App4
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MatriculaPage : ContentPage
	{
        // vetor de disciplinas
        Disciplina[] disciplinas = new Disciplina[4]
        {
            new Disciplina("Calc 1", 1, 1),
            new Disciplina("Calc 2", 2, 2),
            new Disciplina("Calc 3", 3, 3),
            new Disciplina("Calc 4", 4, 4)
        };
        public MatriculaPage ()
		{
			InitializeComponent ();
            foreach (Disciplina disciplinas in disciplinas)
            {
                // adicionar um elemento na caixa de seleção
                Picker02.Items.Add(disciplinas.Nome + "-" + disciplinas.Semestre + "-" + disciplinas.Professor);
            }
            foreach (Aluno alunos in Listas.Alunos)
            {
                // adicionar um elemento na caixa de seleção
                Picker01.Items.Add(alunos.Periodo + " " + alunos.Nome);
            }
        }
        void OnButtonClicked(object sender, EventArgs args)
        {
            // verificar as entradas
            // verificar se os campos foram preenchidos
            if (Picker01.SelectedIndex >= 0 &&
                Picker02.SelectedIndex >= 0)
            {
                if (Entry01.Text != null &&
                    Entry01.Text.Length > 0)
                {
                    Aluno aluno = Listas.Alunos.ElementAt(Picker01.SelectedIndex);
                    Disciplina disciplina = disciplinas[Picker02.SelectedIndex];
                    int resultado = aluno.Matricular(disciplina, int.Parse(Entry01.Text));
                    label01.Text = resultado.ToString();
                }
                else
                {
                    Aluno aluno = Listas.Alunos.ElementAt(Picker01.SelectedIndex);
                    Disciplina disciplina = disciplinas[Picker02.SelectedIndex];
                    int resultado = aluno.Matricular(disciplina);
                    label01.Text = resultado.ToString();
                }
                
            }
        }
    }
}