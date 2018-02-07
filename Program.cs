using System;
using AblExpressionEvaluator.Evaluator;

namespace AblExpressionEvaluator {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine(PreprocExpressionEvaluator.EvaluateExpression("TRUE"));
            Console.WriteLine(PreprocExpressionEvaluator.EvaluateExpression(@"""yop"" BEGINS ""yo"""));
            Console.WriteLine(PreprocExpressionEvaluator.EvaluateExpression(@"SUBSTRING(""str"", 1, 1) = ""s"""));
            //...
            Console.Read();
        }
    }
}
