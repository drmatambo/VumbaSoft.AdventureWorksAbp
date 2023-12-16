$(function () {

    $("#StateProvinceFilter :input").on('input', function () {
        dataTable.ajax.reload();
    });

    //After abp v7.2 use dynamicForm 'column-size' instead of the following settings
    //$('#StateProvinceCollapse div').addClass('col-sm-3').parent().addClass('row');

    var getFilter = function () {
        var input = {};
        $("#StateProvinceFilter")
            .serializeArray()
            .forEach(function (data) {
                if (data.value != '') {
                    input[abp.utils.toCamelCase(data.name.replace(/StateProvinceFilter./g, ''))] = data.value;
                }
            })
        return input;
    };

    var l = abp.localization.getResource('AdventureWorksAbp');

    var service = vumbaSoft.adventureWorksAbp.demographics.stateProvinces.stateProvince;
    var createModal = new abp.ModalManager(abp.appPath + 'Demographics/StateProvinces/StateProvince/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'Demographics/StateProvinces/StateProvince/EditModal');

    var dataTable = $('#StateProvinceTable').DataTable(abp.libs.datatables.normalizeConfiguration({
        processing: true,
        serverSide: true,
        paging: true,
        searching: false,//disable default searchbox
        autoWidth: false,
        scrollCollapse: true,
        order: [[0, "asc"]],
        ajax: abp.libs.datatables.createAjax(service.getList,getFilter),
        columnDefs: [
            {
                rowAction: {
                    items:
                        [
                            {
                                text: l('Edit'),
                                visible: abp.auth.isGranted('Demographics.StateProvince.Update'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l('Delete'),
                                visible: abp.auth.isGranted('Demographics.StateProvince.Delete'),
                                confirmMessage: function (data) {
                                    return l('StateProvinceDeletionConfirmationMessage', data.record.id);
                                },
                                action: function (data) {
                                    service.delete(data.record.id)
                                        .then(function () {
                                            abp.notify.info(l('SuccessfullyDeleted'));
                                            dataTable.ajax.reload();
                                        });
                                }
                            }
                        ]
                }
            },
            {
                title: l('StateProvinceCountryId'),
                data: "countryId"
            },
            {
                title: l('StateProvinceRegionId'),
                data: "regionId"
            },
            {
                title: l('StateProvinceName'),
                data: "name"
            },
            {
                title: l('StateProvincePopulation'),
                data: "population"
            },
            {
                title: l('StateProvinceRegionCode'),
                data: "regionCode"
            },
            {
                title: l('StateProvinceStateProvinceCode'),
                data: "stateProvinceCode"
            },
            {
                title: l('StateProvinceRemarks'),
                data: "remarks"
            },
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewStateProvinceButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
