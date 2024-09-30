var dataTable;
$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#nssftblbody').DataTable({
        "ajax": {
            "url": "/Admin/Nssf/GetAll"
        },
        "columns": [
            { "data": "national_avg_earning", "width": "15%" },
            { "data": "upper_earning_limit_per", "width": "15%" },
            { "data": "upper_earning_limit_amnt", "width": "15%" },
            { "data": "lower_earning_limit_amnt", "width": "15%" },
            { "data": "employee_percent", "width": "15%" },
            { "data": "employer_percent", "width": "15%" },
            {
                "data": "id",
                "render": function (data) {
                    return `<div class="font-sans-serif btn-reveal-trigger position-static">
                                    <button class="btn btn-sm dropdown-toggle dropdown-caret-none transition-none btn-reveal fs--2" type="button" data-bs-toggle="dropdown" data-boundary="window" aria-haspopup="true" aria-expanded="false" data-bs-reference="parent"><span class="fas fa-ellipsis-h fs--2"></span></button>
                                    <div class="dropdown-menu dropdown-menu-end py-2"><a class="dropdown-item" href="/Admin/Nssf/Upsert?id=${data}">Edit</a><a class="dropdown-item text-danger" onClick=Delete('/Admin/Nssf/Delete/${data}')>Delete</a>
                                    </div>
                                  </div>`
                },
                "width":"1%",
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