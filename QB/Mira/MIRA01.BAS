REDIM AA(10)
REDIM BB(10)
REDIM xx(10)
REDIM yy(10)
REDIM WXX1(6)
REDIM WYY1(6)
REDIM WXX2(6)
REDIM WYY2(6)

AA(1) = -0.4: BB(1) = 1
AA(2) = -0.4: BB(2) = 1
AA(3) = -0.2: BB(3) = 1
AA(4) = -0.48: BB(4) = 0.93
AA(5) = -0.4: BB(5) = 0.99
AA(6) = -0.25: BB(6) = 0.998

WXX1(1) = -24: WYY1(1) = -18
WXX1(2) = -40: WYY1(2) = -32
WXX1(3) = -24: WYY1(3) = -18
WXX1(4) = -16: WYY1(4) = -14
WXX1(5) = -16: WYY1(5) = -12
WXX1(6) = -16: WYY1(6) = -12

WXX2(1) = 24: WYY2(1) = 18
WXX2(2) = 40: WYY2(2) = 32
WXX2(3) = 24: WYY2(3) = 18
WXX2(4) = 16: WYY2(4) = 10
WXX2(5) = 16: WYY2(5) = 12
WXX2(6) = 16: WYY2(6) = 12

xx(1) = 4: yy(1) = 0
xx(2) = 20: yy(2) = 0
xx(3) = 10: yy(3) = 0
xx(4) = 4: yy(4) = 0
xx(5) = 4: yy(5) = 0
xx(6) = 3: yy(6) = 0

SCREEN 12

FOR M = 1 TO 6

    CLS

    WINDOW (WXX1(M), WYY1(M))-(WXX2(M), WYY2(M))

    P = 12000
    C = 2 - 2 * AA(M)

    W = AA(M) * xx(M) + C * xx(M) * xx(M) / (1 + xx(M) * xx(M))
    FOR N = 0 TO P
        IF N > 100 THEN PSET (xx(M), yy(M)), M
        Z = xx(M)
        xx(M) = BB(M) * yy(M) + W
        U = xx(M) * xx(M)
        W = AA(M) * xx(M) + C * U / (1 + U)
        yy(M) = W - Z
    NEXT N
    INPUT "RETERN",R$
NEXT M


