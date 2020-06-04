namespace PolimorfismoPOO
{
    public class Luigi : Player
    {
        public override void Pular(){
           
            //aproveitando as ações da super classe

            base.Pular();
            //adicionando novas ações
            System.Console.WriteLine("O Luigi também pode pular 30% mais alto ");
    }
    }
}