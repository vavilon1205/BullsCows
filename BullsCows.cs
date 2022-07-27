

class BullsCows : Window
{
    Random rnd = new Random();
    int steps = 0, bulls = 0, cows = 0;
    char[] enigma;




    void Init(int n = 4)
    {
        char[] abc = "0123456789".ToCharArray();

        for (int i = 0; i < 4; i++)
        {
            var j = rnd.Next(i + 1, 10);
            (abc[i], abc[j]) = (abc[j], abc[i]);
        }

        enigma = abc[..n];
    }
    bool Verification(string gip, out string error)
    {
        error = "";
        
        if (gip.Length != 4)
        {
            error = "Нужно ЧЕТЫРЕ различные цифры";
        }

        else if (gip.Distinct().Count() != 4)
        {
            error = "Нужно четыре РАЗЛИЧНЫЕ цифры";
        }
        else if (!gip.All(c => char.IsDigit(c)))
        {
            error = "Нужно четыре различные ЦИФРЫ";
        }

        return string.IsNullOrEmpty(error);

    }




    void Loop()
    {
        do
        {
            steps++;
            
            var gip = Input();
            if (string.IsNullOrEmpty(gip))
            {
                break;
            }
            else if(Verification(gip, out var error))
            {

                bulls = 0; cows = 0;
                for (int i = 0; i < 4; i++)
                {
                    if (gip[i] == enigma[i])
                    {
                        bulls++;
                    }
                    else if (enigma.Contains(gip[i]))
                    {
                        cows++;
                    }
                }
                if (bulls == 4)
                {
                    Print("You WIN!!!");

                }
                else
                {
                    Print(" Steps: ", steps, " Bulls: ", bulls, " Cows: ", cows);

                    Print($"");
                }

            }
            else
            {
                Print(error);
            }

        } while (bulls < 4);
    }
    
   
    public void Run()
    {
        Init(4);
        Loop();

        Print("Заходи еще!");
        Input();


    }




}



