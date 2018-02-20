from django.shortcuts import render, redirect
from django.http import HttpResponse
from apps.habitacion.forms import HabitacionForm
from apps.habitacion.models import Habitacion
# Create your views here.

def index_Habitacion(request):
    return render(request, 'habitacion/Hindex.html')

# Guardar habitacion
def habitacion_view(request):
    if request.method == 'POST':
        form = HabitacionForm(request.POST)
        if form.is_valid():
            form.save()
        return redirect('Hindex')
    else:
        form = HabitacionForm()
    return render(request, 'habitacion/habitacion_form.html', {'form':form})

# Mostrar habitacion
def lista_habitacion(request):
    habitacion = Habitacion.objects.all().order_by('id')
    p = {'habitaciones':habitacion}
    return render(request, 'habitacion/lista_habitacion.html', p)

# Editar habitacion
def editar_habitacion(request, idHab):
    habitacion = Habitacion.objects.get(id = idHab)
    if request.method == 'GET':
        form = HabitacionForm(instance=habitacion)
    else:
        form = HabitacionForm(request.POST, instance = habitacion)
        if form.is_valid():
            form.save()
        return redirect('ver_habitacion')
    return render(request, 'habitacion/habitacion_form.html', {'form':form})

# Eliminar habitacion
def eliminar_habitacion(request, idHab):
    habitacion = Habitacion.objects.get(id = idHab)
    if request.method == 'POST':
        habitacion.delete()
        return redirect('ver_habitacion')
    return render(request, 'habitacion/eliminar_habitacion.html', {'habitacion':habitacion})
