# Generated by Django 2.0 on 2017-12-07 19:05

from django.db import migrations, models


class Migration(migrations.Migration):

    initial = True

    dependencies = [
    ]

    operations = [
        migrations.CreateModel(
            name='Cliente',
            fields=[
                ('id', models.AutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('Nombre', models.CharField(max_length=35)),
                ('ApellidoPaterno', models.CharField(max_length=35)),
                ('ApellidoMaterno', models.CharField(max_length=35)),
                ('FechaNacimiento', models.DateField()),
                ('Telefono', models.CharField(max_length=10)),
                ('Email', models.EmailField(max_length=254)),
            ],
        ),
    ]
