using HHW.Tools.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HHW.Tools.TrackMaker
{
    public class Storm : TrackMaker
    {
        public int currentId; // field - current storm id
        public int Id { get; set; }
        public string name { get; set; }
        public List<Node> nodeList { get; set; } 

        // Constructor for the Storm class.

        public Storm(string name = "")
        {
            this.name = name;
            nodeList = new List<Node>();
            AddStorm(this); // add a storm.
        }


    }

    public class Node
    {
        public SolidColorBrush colour { get; set; }
        public int category { get; set; } // replace with a struct?
        public int intensity { get; set; }
        public int posX { get; set; }
        public int posY { get; set; }
        public Node(Storm storm, SolidColorBrush colour, int category, int intensity, int posX, int posY) // this initalizes the node
        {
            this.colour = colour;
            this.category = category;
            this.intensity = intensity;
            this.posX = posX;
            this.posY = posY;
            storm.nodeList.Add(this);
        }

    }
}
