using System;
using System.Collections.Generic;
using System.Text;
using System.Media;
using NAudio.Wave;

namespace mors
{
    class Alphabet
    {
        private static IDictionary<char, string> codes = new Dictionary<char, string>
        {
            {'A',".-"    },
            {'B',"-..."  },
            {'C',"-.-."  },
            {'D',"-.."   },
            {'E',"."     },
            {'F',"..-."  },
            {'G',"--."   },
            {'H',"...."  },
            {'I',".."    },
            {'J',".---"  },
            {'K',"-.-"   },
            {'L',".-.."  },
            {'M',"--"    },
            {'N',"-."    },
            {'O',"---"   },
            {'P',".--."  },
            {'R',".-."   },
            {'S',"..."   },
            {'T',"-"     },
            {'U',"..-"   },
            {'V',"...-"  },
            {'Y',"-.--"  },
            {'Z',"--.."  },
            {' ' ," " }
        };

        private static IDictionary<string, char> letters = new Dictionary<string, char>
        {
            {".-"   ,'A' },
            {"-..." ,'B' },
            {"-.-." ,'C' },
            {"-.."  ,'D' },
            {"."    ,'E' },
            {"..-." ,'F' },
            {"--."  ,'G' },
            {"...." ,'H' },
            {".."   ,'I' },
            {".---" ,'J' },
            {"-.-"  ,'K' },
            {".-.." ,'L' },
            {"--"   ,'M' },
            {"-."   ,'N' },
            {"---"  ,'O' },
            {".--." ,'P' },
            {".-."  ,'R' },
            {"..."  ,'S' },
            {"-"    ,'T' },
            {"..-"  ,'U' },
            {"...-" ,'V' },
            {"-.--" ,'Y' },
            {"--.." ,'Z' }
        };

        private static char getLetter(string morsCode)
        {
            char ch;
            if (letters.TryGetValue(morsCode, out char val))
            {
                ch = val;
            }
            else
            {
                ch = '?';
            }
            return ch;
        }

        public static string getText(string morsCode)
        {
            string ret = "";
            string[] codes = morsCode.Split(' ');
            for (int i = 0; i < codes.Length; i++)
            {
                char letterOfCode = getLetter(codes[i]);
                ret += letterOfCode + " ";
            }
            return ret;
        }

        private static string getCodeOfLetter(char letter)
        {
            string code;
            if (codes.TryGetValue(letter, out string val))
            {
                code = val;
            }
            else
            {
                code = "?";
            }
            return code;
        }

        public static string getCodeOfLetters(string letters)
        {
            letters = letters.Trim(' ');
            char[] _letters = letters.ToCharArray();
            string ret = "";

            for (int i = 0; i < _letters.Length; i++)
            {
                string codeOfLetter = getCodeOfLetter(_letters[i]);

                /*  
                    sesli mors alfabesine çevirmek denenebilir
                     
                    using (var waveOut = new WaveOutEvent())
                    {
                        using (var wavReader = new WaveFileReader("uzun.wav"))
                        {
                            waveOut.Init(wavReader);
                            waveOut.Play();
                        }
                    }
                */


                ret += codeOfLetter + " ";
            }
            return ret;
        }


    }
}
