using System;
using System.Collections.Generic;
using System.Text;

namespace App4.Modelos
{
    class Aluno
    {
        // atributo nome
        private String nome;

        public String Nome
        {
            get
            {
                return this.nome;
            }
        }

        // atributo matrícula
        private String matricula;

        public String Matricula
        {
            get
            {
                return this.matricula;
            }
        }

        // atributo período
        private int periodo;

        public int Periodo
        {
            get
            {
                return this.periodo;
            }
            set
            {
                if (value >= 1 && value <= 8)
                {
                    this.periodo = value;
                    // chama o método interno para calcular a formatura
                    this.Formar();
                }
            }
        }

        // atributo formatura
        private int formatura;

        public int Formatura
        {
            get
            {
                return this.formatura;
            }
        }

        public Aluno(String nome, String matricula) : this(nome, matricula, 1)
        {
        }

        public Aluno(String nome, String matricula, int periodo)
        {
            this.nome = nome;
            this.matricula = matricula;
            this.periodo = periodo;
        }

        private void Formar()
        {
            // modifica o valor da formatura
            this.formatura = 8 - this.periodo;
        }
        // método para verificar se é possível a matrícula do aluno na disciplina
        public int Matricular(Disciplina disciplina, int periodo)
        {
            // verificar disciplina em atraso
            if (disciplina.Semestre < this.periodo)
            {
                // retorna a média entre o que se deseja e o que resta
                return (periodo + this.formatura) / 2;
            } else
            {
                // retorna p semestre da disciplina
                return disciplina.Semestre;
            }
        }
        //exercioc 3.1
        public int Matricular(Disciplina disciplina)
        {
           if(disciplina.Semestre < this.periodo)
            {
                return (disciplina.Semestre + this.formatura);
            }
            else
            {
                return disciplina.Semestre;
            }
        }

    }
}
