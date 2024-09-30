var dataTable;
$(document).ready(function () {
    /* loadDataTable();*/
    
    $("#checkedAll").change(function () {
        if (this.checked) {
            $(".checkSingle").each(function () {
                this.checked = true;
            });
        } else {
            $(".checkSingle").each(function () {
                this.checked = false;
            });
        }
    });

    $(".checkSingle").click(function () {
        if ($(this).is(":checked")) {
            var isAllChecked = 0;

            $(".checkSingle").each(function () {
                if (!this.checked)
                    isAllChecked = 1;
            });

            if (isAllChecked == 0) {
                $("#checkedAll").prop("checked", true);
            }
        }
        else {
            $("#checkedAll").prop("checked", false);
        }
    });

    //Post Data

    document.getElementById('btnpostdata').addEventListener('click',
        function (event) {
            event.preventDefault();
            //debugger
            var nightshiftdata = [];
            var table = $('#nightshifthourspostingtblbody').DataTable();
            if ($('[name="chkBox"]:checked').length <= 0) {
                alert('Please select minimum one data');
                exit();
            }
            else {

                $('[name="chkBox"]:checked').each(function (data) {

                    var row = $(this).closest("tr");
                    var data = $('#nightshifthourspostingtblbody').DataTable().row(row).data();                                   

                    nightshiftdata.push({
                        "Id": data['id'],
                        "EmpId": data['employeeId'],
                        "DatePosted": data['datePosted'],
                        "HoursWorked": parseFloat(data['hoursWorked']).toFixed(2),                            
                        "Picked":false,
                    });


                });

                var dataToPost = JSON.stringify({ nightshiftdata });
                //var dataToPost = JSON.stringify(model);
                

                $.ajax({                                     
                    type: "post",
                    dataType: "json",
                    url: '/Admin/NightshiftHoursPosting/PostNightShift',  
                    data: JSON.stringify(nightshiftdata),
                    contentType: "application/json; charset=utf-8",
                    traditional: true,
                    success: function (data) {
                        
                        if (data.success === true)
                        {
                            location.reload({ forceReload: true });
                        }
                        //location.reload({ forceReload: true }); // reload the page
                    },
                    error: function (e)
                    {
                        console.log('--error--');

                    }
                });

            }
        });

    $('#btnretrievedata').click(function () {   
      
        loadDataTable($("#fromdatepicker").val(), $("#todatepicker").val());
    });

   


});

function formatDate(date) {
    var d = new Date(date),
        month = '' + (d.getMonth() + 1),
        day = '' + d.getDate(),
        year = d.getFullYear();

    if (month.length < 2)
        month = '0' + month;
    if (day.length < 2)
        day = '0' + day;

    return [year, month, day].join('-');
}

function loadDataTable(fromDate, toDate ) {
    
    dataTable = $('#nightshifthourspostingtblbody').DataTable({
        destroy: true,
        "ajax": {
            "url": "/Admin/NightshiftHoursPosting/GetAllByDate",
            "data": {
                fromDate: fromDate,
                toDate: toDate,
            },
        },
        columnDefs: [{
            target: 3,
            render: DataTable.render.datetime("DD-MM-YYYY")
        }],
        "columns": [
            { "data": "id", "width": "5%", "sClass": "align-middle" },
            { "data": "employee.id", "width": "5%", "sClass": "align-middl " },
            { "data": "employee.fullNameWithCode", "width": "25%", "sClass": "align-middle" },
            { "data": "datePosted", "width": "5%", "sClass": "align-middle" },
            { "data": "hoursWorked", "width": "5%", "sClass": "align-middle" },
            {
                "data": "employeeId",
                "render": function (data) {
                    return `<input class="form-check-input checkSingle" id = "${data}" value="${data}" name="chkBox" type="checkbox" data-bulk-select-row="{&quot;name&quot;:&quot;Anna&quot;,&quot;email&quot;:&quot;anna@example.com&quot;,&quot;age&quot;:18}" />`
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




