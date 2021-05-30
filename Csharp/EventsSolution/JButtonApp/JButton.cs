using System;

namespace JButtonApp
{
    class JButton
    {
        public event Action<JButton> OnButtonClick;
        private string _title;
        private int _width;
        private int _height;

        public int Width
        {
            get
            {
                return _width;
            }

            set
            {
                _width = value;
            }
        }

        public int Height
        {
            get
            {
                return _height;
            }

            set
            {
                _height = value;
            }
        }

        public JButton(string title,int width,int height)
        {
            _title = title;
            _width = width;
            _height = height;
        }

        public void OnClick(int h,int w)
        {
            Height = h;
            Width = w;
            if(OnButtonClick != null)
            {
                OnButtonClick(this);
            }
        }
    }
}
