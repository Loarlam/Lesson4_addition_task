using System;

namespace Addition_task
{
    class Body : A4Sheet
    {
        string _content;

        public override string Content
        {
            get
            {
                if (_content != null)
                    return _content;
                else
                    return "Тело документа отсутствует.";
            }
            set
            {
                _content = value;
            }
        }

        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
