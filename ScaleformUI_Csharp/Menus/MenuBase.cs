﻿using ScaleformUI.Menu;
using ScaleformUI.Scaleforms;

namespace ScaleformUI.Menus
{
    public class MenuBase
    {
        private bool visible;
        public virtual bool Visible
        {
            get => visible;
            set
            {
                visible = value;
                MenuHandler.ableToDraw = value;
            }
        }
        public List<InstructionalButton> InstructionalButtons { get; set; }
        internal virtual void ProcessControl()
        {

        }
        internal virtual void ProcessMouse()
        {

        }
        internal virtual void Draw()
        {
        }
    }
}
