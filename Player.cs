namespace PolimorfismoPOO
{
    public class Player
    {
        
        public virtual void Pular(){
            System.Console.WriteLine("O personagem está pulando normalmente");
        }
        //virtual é um modificador SEMPRE na classe pai
        public virtual void Correr(){
            System.Console.WriteLine("O personagem está andando normalmente");
        }
    }
}