using Lesson7.Interfaces;

namespace Lesson7
{
    public class ACoder : IСoder
    {
        /// <summary>
        /// Счетчик шифровки и расшифровки, нельзя зашифровать уже зашифрованную строку, как и нельзя расшифровать незашифрованную строку
        /// </summary>
        private static int count = 0;

        private string _changeString;
        
        /// <summary>
        /// Создал два массива с символами, только кириллица
        /// </summary>
        readonly char[] symbol = {'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я'};
        readonly char[] symbol2 = { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я' };



        public ACoder(string changeString)
        {
            _changeString = changeString;
        }

        /// <summary>
        /// Расшифровка строки, без учета цифр. Проверка счетчика осуществляется здесь же (куда стоит перенести?)
        /// </summary>
        /// <param name="word">Строка</param>
        /// <returns></returns>
        public string Decode()
        {   
            if (count == 0)
            {
                return "Для расшифровки зашифруйте строку";
            }
            count = 0;
            //Разбиение входящей строки на массив символов
            char[] symbolChange = _changeString.ToCharArray();
            int a = 0;
            while (a < symbolChange.Length)
            {
                for (int i = 0; i < symbol.Length; i++)
                {
                    if (symbolChange[a] == symbol[0])
                    {
                        symbolChange[a] = symbol[symbol.Length - 1];
                        break;
                    }

                    if (symbolChange[a] == symbol[i])
                    {
                        symbolChange[a] = symbol[i - 1];
                        break;
                    }
                }

                for (int i = 0; i < symbol2.Length; i++)
                {
                    if (symbolChange[a] == symbol2[0])
                    {
                        symbolChange[a] = symbol2[symbol2.Length - 1];
                        break;
                    }

                    if (symbolChange[a] == symbol2[i])
                    {
                        symbolChange[a] = symbol2[i - 1];
                        break;
                    }
                }

                a++;

            }

            return _changeString = new string(symbolChange);
        }

        /// <summary>
        /// Зашифровка строки, без учета цифр. Проверка счетчика осуществляется здесь же (куда стоит перенести?)
        /// </summary>
        /// <param name="word">Строка</param>
        /// <returns></returns>
        public string Encode()
        {
            if (count == 1)
            {
                return "Строка уже зашифрована";                
            }
            count = 1;
            //Разбиение входящей строки на массив символов
            char[] symbolChange = _changeString.ToCharArray();
            int a = 0;
            while (a < symbolChange.Length)
            {
                for (int i = 0; i < symbol.Length; i++)
                {
                    if (symbolChange[a] == symbol[symbol.Length - 1])
                    {
                        symbolChange[a] = symbol[0];
                        break;
                    }

                    if (symbolChange[a] == symbol[i])
                    {
                        symbolChange[a] = symbol[i + 1];
                        break;
                    }
                }

                for (int i = 0; i < symbol2.Length; i++)
                {
                    if (symbolChange[a] == symbol2[symbol2.Length - 1])
                    {
                        symbolChange[a] = symbol2[0];
                        break;
                    }

                    if (symbolChange[a] == symbol2[i])
                    {
                        symbolChange[a] = symbol2[i + 1];
                        break;
                    }
                }

                a++;

            }

            return _changeString = new string (symbolChange);

        }
    }
}
