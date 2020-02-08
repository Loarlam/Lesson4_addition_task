using System;

namespace Addition_task
{
    class Title : A4Sheet
    {
        string _content;

        public override string Content
        {
            get
            {
                if (_content != null)
                    return _content;
                else
                    return "Заголовок отсутствует.";
            }
            set
            {
                _content = value;
            }
        }

        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
