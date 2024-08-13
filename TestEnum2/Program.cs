﻿using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

namespace TestEnum2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Java5 is true");

            Test("input1", true);
            Test("input2", true);

            Console.WriteLine();
            Console.WriteLine("Java5 is false");

            Test("input1", false);
            Test("input2", false);
        }

        private static void Test(string fileName, bool java5)
        {
            Enum2Lexer.Java5 = java5; // in lexer not parser

            using TextReader text_reader = File.OpenText(fileName);

            // Create an input character stream from standard in
            var input = new AntlrInputStream(text_reader);
            // Create an ExprLexer that feeds from that stream
            Enum2Lexer lexer = new Enum2Lexer(input);
            // Create a stream of tokens fed by the lexer
            CommonTokenStream tokens = new CommonTokenStream(lexer);
            // Create a parser that feeds off the token stream
            Enum2Parser parser = new Enum2Parser(tokens);

            parser.RemoveErrorListeners(); // remove ConsoleErrorListener
            parser.AddErrorListener(new UnderlineListener()); // add ours

            // Begin parsing at prog rule
            IParseTree tree = parser.prog();

            Console.WriteLine(tree.ToStringTree(parser)); // print LISP-style tree
        }
    }
}