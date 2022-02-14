using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSL
{
    public class PlayerHuman : Player
    {
        //public PlayerHuman(string name)
        //{
        // this.name = "PlayerFlesh";

        //}
        public PlayerHuman()
        {
            AddGesture();
        }

        public override void ChooseGesture()
        {
            
            Console.WriteLine("Choose a Gesture of Scissors, Paper, Rock, Lizard, or Spock");
            DisplayOptions();
            string option = Console.ReadLine();
            
            gestureChoosen = gestures[Convert.ToInt32(option)];
            return;

        }

        static void DisplayOptions()
        {
            var p1 = new PlayerHuman();
            for (int i = 0; i < p1.gestures.Count; i++)
            {
                Console.WriteLine($"Select {i} for {p1.gestures[i]}");
            }
        }


    }
}