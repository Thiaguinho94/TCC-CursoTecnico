using System;


namespace Pesq_Cadastro
{
    internal class RnCadastro
    {
        public int MAX_ID_FROM_DB { get; set; }

        public bool IsCPF(string valor)
        {
            if (valor == "")
            { return false; }

            valor = valor.Replace(" ", "");

            string cpf = valor;

            int d1, d2;
            int soma = 0;

            // Pesos para calcular o primeiro digito
            int[] peso1 = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            // Pesos para calcular o segundo digito
            int[] peso2 = new int[] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] n = new int[11];
            // Se o tamanho for < 11 entao retorna como inválido
            if (cpf.Length != 11)
            { return false; }

            // Caso coloque todos os numeros iguais

            bool retorna_validacaoCPF = Cpf_mesmoNum(cpf);

            if (retorna_validacaoCPF == false)
            { return false; }
            try
            {
                // Quebra cada digito do CPF
                n[0] = Convert.ToInt32(cpf.Substring(0, 1));
                n[1] = Convert.ToInt32(cpf.Substring(1, 1));
                n[2] = Convert.ToInt32(cpf.Substring(2, 1));
                n[3] = Convert.ToInt32(cpf.Substring(3, 1));
                n[4] = Convert.ToInt32(cpf.Substring(4, 1));
                n[5] = Convert.ToInt32(cpf.Substring(5, 1));
                n[6] = Convert.ToInt32(cpf.Substring(6, 1));
                n[7] = Convert.ToInt32(cpf.Substring(7, 1));
                n[8] = Convert.ToInt32(cpf.Substring(8, 1));
                n[9] = Convert.ToInt32(cpf.Substring(9, 1));
                n[10] = Convert.ToInt32(cpf.Substring(10, 1));
            }
            catch
            {
                return false;
            }

            // Calcula cada digito com seu respectivo peso
            for (int i = 0; i <= peso1.GetUpperBound(0); i++)
            { soma += peso1[i] * Convert.ToInt32(n[i]); }

            // Pega o resto da divisao
            int resto = soma % 11;

            d1 = resto == 1 || resto == 0 ? 0 : 11 - resto;

            soma = 0;

            // Calcula cada digito com seu respectivo peso
            for (int i = 0; i <= peso2.GetUpperBound(0); i++)
            { soma += peso2[i] * Convert.ToInt32(n[i]); }

            // Pega o resto da divisao
            resto = soma % 11;
            d2 = resto == 1 || resto == 0 ? 0 : 11 - resto;

            string calculado = d1.ToString() + d2.ToString();
            string digitado = n[9].ToString() + n[10].ToString();

            // Se os ultimos dois digitos calculados bater com
            // os dois ultimos digitos do cpf entao é válido
            return calculado == digitado;
        }

        private bool Cpf_mesmoNum(string cpf)
        {
            switch (cpf)
            {
                case "11111111111":
                    return false;
                case "00000000000":
                    return false;
                case "22222222222":
                    return false;
                case "33333333333":
                    return false;
                case "44444444444":
                    return false;
                case "55555555555":
                    return false;
                case "66666666666":
                    return false;
                case "77777777777":
                    return false;
                case "88888888888":
                    return false;
                case "99999999999":
                    return false;
                default:
                    break;
            }
            return true;
        }
    }
}