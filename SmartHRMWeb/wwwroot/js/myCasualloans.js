var dataTable;
$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblCLoanData').DataTable({
        "ajax": {
            "url": "/Admin/CLoan/GetAll"
        },
        "columns": [           
            { "data": "employee.empCode", "width": "7%" },
            { "data": "employee.fullName", "width": "25%" },
            { "data": "payrollCode.code", "width": "6%" },
            { "data": "payrollCode.payName", "width": "20%" },
            { "data": "loanStartPeriod", "width": "12%" },    
            { "data": "loanEndPeriod", "width": "12%" },
            { "data": "interestRate", "width": "6%" },
            { "data": "numberOfPeriods", "width": "6%" },
            {
                mData: 'loanAmount', "width": "12%", render: $.fn.dataTable.render.number(',', '.', 2, '')
            },         
            {
                "data": "id",
                "render": function (data) {

                    return `<td class="align-middle white-space-nowrap text-end pe-0">
                            <div class="font-sans-serif btn-reveal-trigger position-static">
                              <button class="btn btn-sm dropdown-toggle dropdown-caret-none transition-none btn-reveal fs--2" type="button" data-bs-toggle="dropdown" data-boundary="window" aria-haspopup="true" aria-expanded="false" data-bs-reference="parent"><span class="fas fa-ellipsis-h fs--2"></span></button>
                              <div class="dropdown-menu dropdown-menu-end py-2"><a class="dropdown-item" href="/Admin/CLoan/Schedule?id=${data}">Schedule</a><a class="dropdown-item" href="/Admin/CLoan/Upsert?id=${data}">Edit</a>
                                <div class="dropdown-divider"></div><a class="dropdown-item text-danger" onClick=Delete('/Admin/CLoan/Delete/${data}')">Remove</a>
                              </div>
                            </div>
                          </td>`
                },
                "width":"15%",
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