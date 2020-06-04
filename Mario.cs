namespace PolimorfismoPOO
{
    public class Mario : Player
    {
      public override void Correr(){
            System.Console.WriteLine("O Mario esta correndo mais rápido agora");
            //sobrescrevendo ao original, para isso acontecer usar override
        }  
    }
}