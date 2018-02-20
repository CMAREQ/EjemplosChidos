def hanoi(N, origen='1', dest='3', aux='2'):

    if N > 0:
        hanoi(N-1, origen, aux, dest)
        print ('Se mueve de torre', origen, 'a torre', dest)
        hanoi(N-1, aux, dest, origen)

if __name__ == '__main__':
    discos = int(input("Ingresa el numero de discos: "))
    hanoi(discos)

'''
hanoi ( N, origen, destino, auxiliar )
{
si N mayor a 0 entonces
hanoi(N - 1, origen, auxiliar, destino)
pasar disco N de origen a destino
hanoi(N - 1, auxiliar, destino, origen)
fin-si
}
'''
