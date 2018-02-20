from django.shortcuts import render, redirect
from django.http import HttpResponse
from apps.reservacion.forms import ReservacionForm
from apps.reservacion.models import Reservacion

# Create your views here.

def index_Reservacion(request):
    return render(request, 'reservacion/Rindex.html')

# crear reservacion
def reservacion_view(request):
    if request.method == 'POST':
        form = ReservacionForm(request.POST)
        if form.is_valid():
            form.save()
        return redirect('Rindex')
    else:
        form = ReservacionForm()
    return render(request, 'reservacion/reservacion_form.html', {'form':form})

# Mostrar Reservaciones
def lista_reservacion(request):
    reservacion = Reservacion.objects.all().order_by('id')
    p = {'reservaciones':reservacion}
    return render(request, 'reservacion/lista_reservacion.html', p)

# Editar reservacion
def editar_reservacion(request, idRes):
    reservacion = Reservacion.objects.get(id = idRes)
    if request.method == 'GET':
        form = ReservacionForm(instance=reservacion)
    else:
        form = ReservacionForm(request.POST, instance = reservacion)
        if form.is_valid():
            form.save()
        return redirect('ver_reservacion')
    return render(request, 'reservacion/reservacion_form.html', {'form':form})

# Eliminar reservacion
def eliminar_reservacion(request, idRes):
    reservacion = Reservacion.objects.get(id = idRes)
    if request.method == 'POST':
        reservacion.delete()
        return redirect('ver_reservacion')
    return render(request, 'reservacion/eliminar_reservacion.html', {'reservacion':reservacion})
