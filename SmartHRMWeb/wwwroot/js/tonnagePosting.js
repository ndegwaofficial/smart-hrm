
$(document).ready(function () {

    $.ajax({
        url: "/Admin/TonnagePosting/GetAll",
        type: "GET",

        success: function (data) {

            var table = $("#tonnagePostingRawtblbody tbody");         
            table.empty();
            $.each(data.data, function (i, item) {
               
                table.append(`<tr>` +
                    `<td>` + item.tar.employee.fullNameWithCode + `</td>` +
                    `<td class="align-middle">` + item.tar.employee.contractTypeId + `</td>` +
                    `<td class="align - middle">` + item.tar.period + `</td>` +
                    `<td class="align - middle">` + item.tar.cyear + `</td>` +
                    `<td class="align - middle">` + item.tar.presentDays + `</td>` +
                    `<td class="align - middle">` + item.tar.absentDays + `</td>` +
                    `<td class="align - middle" hidden>` + item.tar.employee.id + `</td>` +
                    `<td class="align - middle" hidden>` + item.tar.id + `</td>` +
                    `<td class="fs--1 align-middle">
                        <input class="form-check-input" id = "${item.tar.id}" value="${item.tar.id}" name="chkBox" type="checkbox" data-bulk-select-row="{&quot;name&quot;:&quot;Anna&quot;,&quot;email&quot;:&quot;anna@example.com&quot;,&quot;age&quot;:18}" />
                    </td>`
                    + "</tr>");

            });


        }

    });



    // add multiple select / deselect functionality
    $("#bulk-select-example").click(function () {
        $('.form-check-input').attr('checked', this.checked);
        //alert('I am here');
    });


    // if all checkbox are selected, check the selectall checkbox     // and viceversa
    $(".form-check-input").click(function () {
        if ($(".form-check-input").length == $(".form-check-input:checked").length) {
            $("#bulk-select-example").attr("checked", "checked");
        }
        else {
            $("#bulk-select-example").removeAttr("checked");
        }
    });



    //Post Data

    document.getElementById('btnpostdata').addEventListener('click',
        function (event) {
            //event.preventDefault();       
            //debugger
            let model = [];
            var table = $('#tonnagePostingRawtblbody').DataTable();
            if ($('[name="chkBox"]:checked').length <= 0) {
                alert('Please select minimum one data');
                exit();
            }
            else {
                var message = "";
                $('[name="chkBox"]:checked').each(function (data) {
                    var row = $(this).closest("tr")[0];
                    model.push({
                        "ContractTypeId": row.cells[1].innerHTML,
                        "Period": row.cells[2].innerHTML,
                        "Cyear": row.cells[3].innerHTML,
                        "PresentDays": row.cells[4].innerHTML,
                        "AbsentDays": row.cells[5].innerHTML,
                        "EmpId": row.cells[6].innerHTML,
                         "Id": row.cells[7].innerHTML
                    });             
                    
                   
                });
               

                $.ajax({
                    url: '/Admin/TonnagePosting/Postdata',
                    type: 'POST',
                    dataType: 'json',
                    data: JSON.stringify(model),
                    contentType: 'application/json; charset=utf-8',
                    success: function (data) {
                        alert('The process was successful');
                        
                    },
                    error: function (e) {
                        console.log('--error--')

                    }
                });

            }
        });

});


