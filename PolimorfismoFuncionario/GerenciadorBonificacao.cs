using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolimorfismoFuncionario
{
    public class GerenciadorBonificacao
    {
        private double totalBonificacao;

        public double TotalBonificacao
        {
            get { return totalBonificacao; }
        }

        public GerenciadorBonificacao()
        {
            totalBonificacao = 0;
        }

        public void TotalizadorBonificacao(Funcionario funcionario)
        {
            this.totalBonificacao += funcionario.CalcularBonificacao();
        }

        public void TotalizadorBonificacao(Secretario secretario)
        {
            this.totalBonificacao += secretario.CalcularBonificacao();
        }

        public void TotalizadorBonificacao(Gerente gerente)
        {
            this.totalBonificacao += gerente.CalcularBonificacao();
        }

        public void TotalizadorBonificacao(Diretor diretor)
        {
            this.totalBonificacao += diretor.CalcularBonificacao();
        }
        
    }
}