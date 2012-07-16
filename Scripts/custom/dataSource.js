/// <reference path="jquery-1.6.4-vsdoc.js" />
/// <reference path="../kendo.all.js" />

var Contrib = {
    routes: function (read, create, update, destroy) {
        return {
            read: read,
            create: create,
            destroy: destroy,
            update: update
        };
    },
    routeSource: function (routes, data) {

        var a = {
            data: {}
        };

        $.extend(a, routes);
        $.extend(a.data, data);

        return a;
    },
    dataSource: function () {

        var pub = {
            dataSource: null,
            commonData: {},
            routes: {
                read: null,
                create: null,
                destroy: null,
                update: null,
                data: {}
            },
            settings: {
                pageSize: 5
            }
        };

        pub.init = function (model, routeSource) {
            jQuery.extend(pub.routes, routeSource);

            var transportType = function (url, type, data) {
                type || (type == "POST");
                data || (data = {});
                return {
                    url: url,
                    type: type,
                    data: data
                };
            };

            var data = pub.routes.data;
            pub.dataSource = new kendo.data.DataSource({
                transport: {
                    read: transportType(pub.routes.read, "GET"),
                    create: transportType(pub.routes.create, "POST", data),
                    destroy: transportType(pub.routes.destroy, "POST", data),
                    update: transportType(pub.routes.update, "POST", data)
                },
                schema: {
                    model: model
                },
                pageSize: pub.settings.pageSize
            });

            //pub.dataSource.read();
        }

        return pub;
    }
}; 

