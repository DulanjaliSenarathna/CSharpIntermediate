using System;
using System.Collections.Generic;
using System.Text;

namespace Multiple_Inheritance
{
    public class TextBox : UiControl ,IDraggable, IDroppable
    {
           public void Drag()
        {

        }

        public void Drop()
        {

        }
    }
   public class UiControl
    {
        public string Id { get; set; }
        public Size Size { get; set; }
        public Position TopLeft { get; set; }

        public virtual void Draw()
        {

        }

        public void Focus()
        {
            Console.WriteLine("Recieved Focus");
        }
    }
}
