$(document).ready(() => {

    $("#gridIndex").DataTable({
        searching: true,
        fixedHeader: true,
        processing: true,
        ajax: {
            url: location.href + "/IndexGrid",
            dataSrc: "tarefas"
        },
        columns: [
            { name: 'id', data: 'id', title: "#", searchable: true },
            { name: 'numero', data: 'numero', title: "Número", autoWidth: true, searchable: true },
            { name: 'assunto', data: 'assunto', title: "Assunto", searchable: true, autoWidth: true },
            { name: 'data_criacao', data: 'data_criacao', title: "Data Criação", autoWidth: true, searchable: true },
            { name: 'data_arquivamento', data: 'data_arquivamento', title: "Data Arquivamento", autoWidth: true, searchable: true },
            { name: 'demandante', data: 'demandante', title: "Demandante", autoWidth: true, searchable: true },
            { name: 'setor_demandante', data: 'setor_demandante', title: "Setor Demandante", autoWidth: true, searchable: true },
        ],
    });
});