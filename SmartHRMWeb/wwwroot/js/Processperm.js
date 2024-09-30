function Confirmedprocessperm(url) { 
    alert(url);
    Swal.fire({
        title: 'Are you sure to continue?',
        text: "Ensure that all trasactions are approved before processing",
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Yes, Process Payroll'
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                url: url,
                type: 'POST',               
                success: function (data) {
                    alert('I am here');
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

