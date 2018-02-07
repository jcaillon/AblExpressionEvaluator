namespace AblExpressionEvaluator.Parser {
    static class Extensions {

        /// <summary>
        /// Does the char array contains a given char
        /// </summary>
        /// <param name="array"></param>
        /// <param name="toFind"></param>
        /// <returns></returns>
        public static bool Contains(this char[] array, char toFind) {
            foreach (var chr in array) {
                if (chr == toFind)
                    return true;
            }
            return false;
        }
    }
}
