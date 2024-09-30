var dataTable;
$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#employeeHoursDaytblbody').DataTable({
        "ajax": {
            "url": "/Admin/EmployeesHoursDay/GetAll"
        },
        "columns": [
            { "data": "employee.empCode", "width": "5%", "sClass": "align-middle" },
            { "data": "employee.fullName", "width": "15%", "sClass": "align-middle" },
            { "data": "transdate", "width": "5%", "sClass": "align-middle" },
            { "data": "hoursdays", "width": "5%", "sClass": "align-middle" },
            { "data": "amount", "width": "5%", "sClass": "align-middle" },          
            {
                "data": "id",
                "render": function (data) {
                    //return `<div class="w-55 btn-group" role="group">
                    //        <a href="/Admin/Employee/Upsert?id=${data}"
                    //        class="btn btn-primary mx-2"><i class="bi bi-pencil-square"></i>Edit</a>
                    //        <a onClick=Delete('/Admin/Employee/Delete/${data}')
                    //       class="btn btn-danger mx-2"><i class="bi bi-trash-fill"></i>Delete</a>
                    //    </div>`
                    return `<div class="font-sans-serif btn-reveal-trigger position-static">
                                    <button class="btn btn-sm dropdown-toggle dropdown-caret-none transition-none btn-reveal fs--2" type="button" data-bs-toggle="dropdown" data-boundary="window" aria-haspopup="true" aria-expanded="false" data-bs-reference="parent"><span class="fas fa-ellipsis-h fs--2"></span></button>
                                    <div class="dropdown-menu dropdown-menu-end py-2"><a class="dropdown-item" href="/Admin/EmployeesHoursDay/Upsert?id=${data}">Edit</a><a class="dropdown-item text-danger" onClick=Delete('/Admin/EmployeesHoursDay/Delete/${data}')>Delete</a>
                                    </div>
                                  </div>`
                },
                "width": "5%",
            },
        ]
    });
}

function Delete(url) {
    Swal.fire({
        title: 'Are you sure?',
        text: "You won't be able to revert this!",
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Yes, delete it!'
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                url: url,
                type: 'DELETE',
                success: function (data) {
                    if (data.success) {
                        dataTable.ajax.reload();
                        toastr.success(data.message);
                    }
                    else {
                        toastr.error(data.message);
                    }
                }
            })
        }
    })
}


