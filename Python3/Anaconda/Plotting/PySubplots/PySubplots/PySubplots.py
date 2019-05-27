from numpy import exp, sin, arange, pi
from pylab import figure, subplot, plot, show

def dsw(t):
    return exp(-t) * sin(2*pi*t)

t1 = arange(0.0, 5.0, 0.1)
t2 = arange(0.0, 5.0, 0.02)

figure(1)

subplot(211)
plot(t1, dsw(t1), t2, dsw(t2), color = 'green')

subplot(212)
plot(t2, sin(2*pi*t2), color = 'yellow')
show()
