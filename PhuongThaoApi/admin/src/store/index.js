import Vue from "vue";
import Vuex from "vuex";
import foods from "./modules/foods";
import employees from "./modules/employees";
Vue.use(Vuex);

export default new Vuex.Store({
    modules: {
        foods,
        employees
    }
})