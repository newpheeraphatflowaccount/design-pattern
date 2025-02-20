﻿using System.Text;

namespace Builder
{
	public class HtmlElement
	{
		public string Name, Text;
		public List<HtmlElement> Elements = new List<HtmlElement>();
		private const int indentSize = 2;

		public HtmlElement()
		{
		}

		public HtmlElement(string name, string text)
		{
			Name = name;
			Text = text;
		}

		private string ToStringImpl(int indent)
		{
			var sb = new StringBuilder();
			var i = new string(' ', indentSize * indent);
			sb.Append($"{i}<{Name}>\n");
			if (!string.IsNullOrWhiteSpace(Text))
			{
				sb.Append(new string(' ', indentSize * (indent + 1)));
				sb.Append(Text);
				sb.Append("\n");
			}

			foreach (var e in Elements)
				sb.Append(e.ToStringImpl(indent + 1));

			sb.Append($"{i}</{Name}>\n");
			return sb.ToString();
		}

		public override string ToString()
		{
			return ToStringImpl(0);
		}
	}

	public class HtmlBuilder
	{
		private readonly string rootName;
		HtmlElement root = new HtmlElement();
		public HtmlBuilder(string rootName)
		{
			this.rootName = rootName;
			root.Name = rootName;
		}

		public void AddChild(string childName, string childText)
		{
			var e = new HtmlElement(childName, childText);
			root.Elements.Add(e);
		}

		public override string ToString()
		{
			return root.ToString();
		}

		public void Clear()
		{
			root = new HtmlElement { Name = rootName };
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			var hello = "hello";
			var sb = new StringBuilder();
			sb.Append("<p>");
			sb.Append(hello);
			sb.Append("</p>");
			Console.WriteLine(sb.ToString());

			var words = new[] { "hello", "world" };
			sb.Clear();
			sb.Append("<ul>");
			foreach (var word in words)
			{
				sb.AppendFormat("<li>{0}</li>", word);
			}
			sb.Append("</ul>");
			Console.WriteLine(sb.ToString());

			var builder = new HtmlBuilder("ul");
			builder.AddChild("li", "hello");
			builder.AddChild("li", "world");
			Console.WriteLine(builder.ToString());
		}
	}
}