<template>
    <div class="employee">
        <header-basic @openForm="openForm">Danh sách nhân viên </header-basic>
        <div class="employee-header-function">
           <input-search />
           <button-refresh />
        </div>
        <div class="employee-table">
            <employee-table />
        </div>
        <dialog-employee :isHide="isHide" @closeForm="closeForm"/>
    </div>
</template>
<script>
import HeaderBasic from '../../components/basic/HeaderBasic.vue'
import ButtonRefresh from '../../components/basic/ButtonRefresh.vue'
import InputSearch from '../../components/basic/InputSearch.vue'
import EmployeeTable from '../../components/employee/EmployeeTable.vue'
import DialogEmployee from '../../components/employee/DialogEmployee.vue'
export default {
  components: { 
    HeaderBasic,
    ButtonRefresh,
    InputSearch,
    EmployeeTable,
    DialogEmployee,
    },
    data() {
        return {
            isHide: true
        }
    },
    methods: {
        openForm: function() {
            this.isHide =!this.isHide
        },
        closeForm: function() {
            this.isHide =!this.isHide
        },
    },
    computed:{
    },
    created(){
    }

    
}
</script>
<style scoped>
.employee-header-function{
    display: flex;
    margin-top: 20px;
    justify-content: space-between;
}
</style>