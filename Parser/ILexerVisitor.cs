﻿#region header
// ========================================================================
// Copyright (c) 2018 - Julien Caillon (julien.caillon@gmail.com)
// This file (ILexerVisitor.cs) is part of 3P.
// 
// 3P is a free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// 3P is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with 3P. If not, see <http://www.gnu.org/licenses/>.
// ========================================================================
#endregion
namespace AblExpressionEvaluator.Parser {
    internal interface ILexerVisitor {
        void PreVisit(Lexer lexer);
        void Visit(TokenComment tok);
        void Visit(TokenEol tok);
        void Visit(TokenEos tok);
        void Visit(TokenInclude tok);
        void Visit(TokenPreProcVariable tok);
        void Visit(TokenNumber tok);
        void Visit(TokenString tok);
        void Visit(TokenStringDescriptor tok);
        void Visit(TokenSymbol tok);
        void Visit(TokenWhiteSpace tok);
        void Visit(TokenWord tok);
        void Visit(TokenEof tok);
        void Visit(TokenUnknown tok);
        void Visit(TokenPreProcDirective tok);
        void PostVisit();
    }
}