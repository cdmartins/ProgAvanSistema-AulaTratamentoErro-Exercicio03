namespace ProgAvanSistema_AulaTratamentoErro_Exercicio03
{
    internal class Login
    {
        private string usuario;
        private string senha;

        public Login(string usuario, string senha)
        {
            this.usuario = "caritadm";
            this.senha = "senha";
        }

        public void setSenha(string senha) { this.senha = senha; }


        /* O método fazerLogin deve receber informações de usuário e senha e compará-las com as da
        classe.Caso sejam realmente iguais, deve retornar verdadeiro, ou então deve lançar uma nova exceção dizendo qual credencial está errada, 
        tratar essa exceção dentro do próprio método imprimindo o erro em tela e por fim retornar false.*/
        public bool fazerLogin(string input_usuario, string input_senha)
        {
            try
            {
                if (this.usuario != input_usuario && this.senha != input_senha)
                {
                    throw new ArgumentException("Senha e usuário inválidos.");
                }
                else if (this.usuario == input_usuario && this.senha == input_senha)
                {
                    Console.WriteLine("Login efetuado com sucesso.");
                    return true;
                }
                else if (this.usuario != input_usuario)
                {
                    throw new ArgumentException("Usuário inválido.");
                }
                else if (this.senha != input_senha)
                {
                    throw new ArgumentException("Senha inválida.");
                }

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return false;
        }
    }
}
