<template>
    <div class="employee">
        <header-basic @openForm="openForm">Danh sách nhân viên </header-basic>
        <div class="employee-table">
            <employee-table />
        </div>
        <dialog-employee :isHide="isHide" @closeForm="closeForm"/>
    </div>
</template>
<script>
import HeaderBasic from '../../components/basic/HeaderBasic.vue'
import EmployeeTable from '../../components/employee/EmployeeTable.vue'
import DialogEmployee from '../../components/employee/DialogEmployee.vue'
export default {
  components: { 
    HeaderBasic,
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
</style>