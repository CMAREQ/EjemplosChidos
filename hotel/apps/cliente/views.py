from django.shortcuts import render, redirect
from django.http import HttpResponse
from apps.cliente.forms import ClienteForm
from apps.cliente.models import Cliente
# Create your views here.

def index_Cliente(request):
    return render(request, 'cliente/Cindex.html')

# Guardar clientes
def cliente_view(request):
    if request.method == 'POST':
        form = ClienteForm(request.POST)
        if form.is_valid():
            form.save()
        return redirect('crear_reservacion')
    else:
        form = ClienteForm()
    return render(request, 'cliente/cliente_form.html', {'form':form})

# Mostrar clientes
def lista_cliente(request):
    cliente = Cliente.objects.all().order_by('id')
    p = {'clientes':cliente}
    return render(request, 'cliente/lista_cliente.html', p)

# Editar clientes
def editar_cliente(request, idCl):
    cliente = Cliente.objects.get(id = idCl)
    if request.method == 'GET':
        form = ClienteForm(instance=cliente)
    else:
        form = ClienteForm(request.POST, instance = cliente)
        if form.is_valid():
            form.save()
        return redirect('ver_cliente')
    return render(request, 'cliente/cliente_form.html', {'form':form})

# Eliminar cliente
def eliminar_cliente(request, idCl):
    cliente = Cliente.objects.get(id = idCl)
    if request.method == 'POST':
        cliente.delete()
        return redirect('ver_cliente')
    return render(request, 'cliente/eliminar_cliente.html', {'cliente':cliente})
