var dataTable;
$(document).ready(function () {
    LoadSchedule(LoanIdx);
    
});

function LoadSchedule(LoanIddata) {
    dataTable = $('#tblCLoanSchedule').DataTable({
        "ajax": {
            "url": "/Admin/CLoan/Loanschedule?id=" + LoanIddata
        },
        "columns": [           
            { "data": "paymentNumber", "width": "7%" },
            { "data": "dueDate", "width": "7%" },
            { "data": "balanceBF", "width": "25%" },
            { "data": "stageRecov", "width": "6%" },
            { "data": "icharge", "width": "20%" },
            { "data": "totalDeduction", "width": "12%" },        
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