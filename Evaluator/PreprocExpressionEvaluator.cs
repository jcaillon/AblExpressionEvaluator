using System.Collections.Generic;
using AblExpressionEvaluator.Parser;

namespace AblExpressionEvaluator.Evaluator {

    internal static class PreprocExpressionEvaluator {

        public static bool EvaluateExpression(string expression) {
            ProLexer proLexer = new ProLexer(expression);
            return EvaluateExpression(proLexer.GetTokensList);
        }

        public static bool EvaluateExpression(List<Token> tokens) {
            // TODO

            /*
            &IF, &THEN, &ELSEIF, &ELSE, and &ENDIF preprocessor directives
            These directives set logical conditions for the inclusion of blocks of code to compile.

            Syntax
            &IF expression &THEN
              block
            [ &ELSEIF expression &THEN
              block]...
            [ &ELSE
              block]
            &ENDIF 

            expression 
            An expression that can contain preprocessor name references, the operators listed in Table 2, the ABL functions listed in Table 3, and the DEFINED( ) preprocessor function. 
            When it encounters an &IF directive, the preprocessor evaluates the expression that immediately follows. This expression can continue for more than one line; the &THEN directive indicates the end of the expression. If the expression evaluates to TRUE, then the block of code between it and the next &ELSEIF, &ELSE, or &ENDIF is compiled. If the expression evaluates to FALSE, the block of code is not compiled and the preprocessor proceeds to the next &ELSEIF, &ELSE, or &ENDIF directive. No include files referenced in this block of code are included in the final source. You can nest &IF directives. 

            The expression that follows the &ELSEIF directive is evaluated only if the &IF expression tests false. If the &ELSEIF expression tests TRUE, the block of code between it and the next &ELSEIF, &ELSE, or &ENDIF directive is compiled. If the &ELSEIF expression tests FALSE, the preprocessor proceeds to the next &ELSEIF, &ELSE, or &ENDIF directive. 

            The block of code between the &ELSE and &ENDIF directives is compiled only if the &IF expression and the &ELSEIF expressions all test false. If there are no &ELSEIF directives, the block of code is compiled if the &IF expression tests false.

            Once any &IF or &ELSEIF expression evaluates to TRUE, no other block of code within the &IF...&ENDIF block is compiled. 

            The &ENDIF directive indicates the end of the conditional tests and the end of the final block of code to compile. 

            The following table shows how preprocessor expressions are evaluated.

            Table 1. Preprocessor expressions Type of expression TRUE FALSE 
            LOGICAL TRUE FALSE 
            CHARACTER non-empty empty 
            INTEGER non-zero 0 
            INT64 non-zero 0 
            DECIMAL not supported not supported 

            The following table lists the operators supported within preprocessor expressions. These operators have the same precedence as the regular ABL operators.

            Table 2. Preprocessor operators Operator Description 
            + Addition 
            - Subtraction 
            * Multiplication 
            / Division 
            = Equality 
            <> Inequality 
            > Greater than 
            < Less than 
            => Greater than or equal to 
            <= Less than or equal to 
            AND Logical and 
            OR Logical or 
            NOT Logical not 
            BEGINS Compares the beginning letters of two expressions 
            MATCHES Compares two strings 

            The following table lists the ABL functions supported within preprocessor expressions.

            Table 3. Functions allowed in preprocessor expressions ABSOLUTE ASC AUDIT-ENABLED 
            DATE DAY DBTYPE 
            DECIMAL ENCODE ENTRY 
            ETIME EXP FILL 
            INDEX INT64 INTEGER 
            KEYWORD KEYWORDALL LC 
            LEFT-TRIM LENGTH LIBRARY 
            LOG LOOKUP MATCHES 
            MAXIMUM MEMBER MINIMUM 
            MODULO MONTH NUM-ENTRIES 
            OPSYS PROCESS-ARCHITECTURE PROPATH 
            PROVERSION RANDOM REPLACE 
            RIGHT-TRIM R-INDEX ROUND 
            SQRT STRING SUBSTITUTE 
            SUBSTRING TIME TODAY 
            TRIM TRUNCATE WEEKDAY 
            YEAR     

            Note
            When the preprocessor evaluates expressions, all arithmetic operations are performed with integers. Preprocessor name references used in arithmetic operations must evaluate to integers.
             *
             */

            return true;
        }
    }
}
