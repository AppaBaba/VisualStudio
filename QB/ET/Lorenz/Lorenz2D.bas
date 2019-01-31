frac = 8 / 3
h = 0.01
X = 0.6
Y = 0.6
Z = 0.6

npts = 4000
SCREEN 12
WINDOW (-25, -60)-(25, 60)


FOR i = 1 TO npts

    Xn = X + h * 10 * (Y - X)
    Yn = Y + h * ((-X * Z) + 28 * X - Y)
    Zn = Z + h * (X * Y - frac * Z)
    X = Xn
    Y = Yn
    Z = Zn

    PSET (X, Y), 5

NEXT i

