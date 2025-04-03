﻿using ProyectoKamil.Data;
using ProyectoKamil.Dto;
using ProyectoKamil.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoKamil
{
    public partial class frmUpdatingDirector : Form
    {
        private EmployeeDto _empleado;
        private int _empleadoId;
        public frmUpdatingDirector(EmployeeDto empleado)
        {
            InitializeComponent();
            _empleado = empleado;
            _empleadoId = empleado.Id;
            ComboBoxLoader.CargarCentroTrabajo(comboBoxWorkCenter);            
            CargarDatos();
        }
        private void CargarDatos()
        {
            textBoxName.Text = _empleado.Nombre ?? "";
            textBoxFatherLastname.Text = _empleado.ApellidoPaterno ?? ""; ;
            textBoxMotherLastname.Text = _empleado.ApellidoMaterno ?? ""; ;
            dateTimePicker.Value = _empleado.FechaNacimiento;
            comboBoxWorkCenter.SelectedValue = _empleado.CentroTrabajo;            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            {
                // 5) Generar RFC
                string rfcCalculado = RFCGenerator.GenerarRFC(textBoxName.Text.Trim(), textBoxFatherLastname.Text.Trim(), textBoxMotherLastname.Text.Trim(), dateTimePicker.Value);

                EmployeeDto nuevoEmpleado = new EmployeeDto
                {
                    Id = _empleadoId,
                    Nombre = textBoxName.Text.Trim(),
                    ApellidoPaterno = textBoxFatherLastname.Text.Trim(),
                    ApellidoMaterno = textBoxMotherLastname.Text.Trim(),
                    FechaNacimiento = dateTimePicker.Value.Date,
                    RFC = rfcCalculado,
                    CentroTrabajo = comboBoxWorkCenter.SelectedValue != null && Convert.ToInt32(comboBoxWorkCenter.SelectedValue) != 0
                         ? Convert.ToInt32(comboBoxWorkCenter.SelectedValue)
                         : 0,
                    Directivo = false
                };


                bool actualizado = EmployeeRepository.UpdateEmpleado(_empleado, nuevoEmpleado);

                if (actualizado)
                    MessageBox.Show("Empleado actualizado correctamente.");
                else
                    MessageBox.Show("No se pudo actualizar el empleado.");
            }
        }
    }
}
