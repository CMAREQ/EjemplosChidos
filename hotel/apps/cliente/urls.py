from django.urls import path
from apps.cliente.views import index_Cliente, cliente_view, lista_cliente, editar_cliente, eliminar_cliente

urlpatterns = [
    path('', index_Cliente, name = 'Cindex'),
    path('nuevo', cliente_view, name = 'crear_cliente'),
    path('ver', lista_cliente, name = 'ver_cliente'),
    path('editar/<idCl>', editar_cliente, name = 'editar_cliente'),
    path('eliminar/<idCl>', eliminar_cliente, name = 'eliminar_cliente'),
]
