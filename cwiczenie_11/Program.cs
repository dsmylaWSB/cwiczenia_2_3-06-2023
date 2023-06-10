/*
 *        |     y = -1      dla x∈(-∞,-2)
 *        |     y = x+1     dla x∈<-2,-1>
 * f(x) = |     y = 0       dla x∈(-1, 1)
 *        |     y = x-1     dla x∈< 1, 2>
 *        |     y = 1       dla x∈( 2, ∞)
 */


double x = -3;
double y = 0;


while (x<=3)
{
    if (x <= -1)
    {
        if (x >= -2)
        {
            y = x + 1;
        }
        else
        {
            y = -1;
        }
    }
    else if (x >= 1)
    {
        if (x <= 2)
        {
            y = x - 1;
        }
        else
        {
            y = 1;
        }
    }
    else
    {
        y = 0;
    }

    Console.WriteLine("x = {0},      y = {1}", x,y);
    x = x + 0.5;
}

