import Vue from "vue";
import Vuex from "vuex";
import foods from "./modules/foods";
import customers from "./modules/customers"
import employees from "./modules/employees"
import user from "./modules/user"
import orders from "./modules/orders"
Vue.use(Vuex);

export default new Vuex.Store({
    state:{

    },
    getters:{},
    actions:{},
    modules: {
        foods,
        customers,
        employees,
        user,
        orders
    }
})