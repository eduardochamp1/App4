using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App4.Modelos;

namespace App4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PeriodoPage : ContentPage
    {
        public PeriodoPage()
        {
            InitializeComponent();
            // para todos os alunos da lista
            foreach (Aluno aluno in Listas.Alunos)
            {
                // adicionar um elemento na caixa de seleção
                Picker.Items.Add(aluno.Matricula + " - " + aluno.Nome);
            }
        }

        void OnButtonClicked(object sender, EventArgs args)
        {
            if (Entry.Text != null &&
                Entry.Text.Length > 0 &&
                Picker.SelectedIndex >= 0)
            {
                // pegar o aluno da lista
                Aluno aluno = Listas.Alunos.ElementAt(Picker.SelectedIndex);
                // alterar o periodo do aluno
                aluno.Periodo = int.Parse(Entry.Text);
                // alterar o label com o valor da formatura
                Label.Text = aluno.Formatura.ToString();
            }
            
        }

    }
}