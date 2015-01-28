namespace HTML_Dispatcher.Engine
{
    public class ElementBuilder
    {
        public ElementBuilder(string elementName)
        {
            this.ElementName = elementName;
        }

        public string ElementName { get; set; }

        public string ElementAttributes { get; set; }

        public string ElementContents { get; set; }

        public void AddAttribute(string elementAttribute, string attributeValue)
        {
            string content = string.Format(
                " {0}=\"{1}\"",
                elementAttribute,
                attributeValue);

            this.ElementAttributes += content;
        }

        public void AddContent(string contentInElement)
        {
            string content = contentInElement;

            this.ElementContents = content;
        }

        public static string operator *(ElementBuilder element, int i)
        {
            string multipliedElement = element.ToString();

            for (int j = 0; j < i; j++)
            {
                multipliedElement += multipliedElement;
            }

            return multipliedElement;
        }

        public override string ToString()
        {
            string htmlElement = string.Format(
                "<{0}{1}>{2}</{0}>",
                this.ElementName,
                this.ElementAttributes,
                this.ElementContents);

            return htmlElement;
        }
    }
}
