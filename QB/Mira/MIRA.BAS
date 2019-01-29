SCREEN 12
CLS
WINDOW (-20, -15)-(20, 15)
A = 0.7
B = .9998
P = 12000
C = 1 - 2 * A
REM STARTING POINT
X = 0
Y = 12.1
W = A * X + C * X * X / (1 + X * X)
FOR N = 0 TO P
    IF N > 100 THEN PSET (X, Y), 5
    IF N > 3000 THEN PSET (X, Y), 6
    IF N > 9000 THEN PSET (X, Y), 3
    Z = X
    X = B * Y + W
    U = X * X
    W = A * X + C * U / (1 + U)
    Y = W - Z
NEXT N
A$ = INPUT$(1)
END
