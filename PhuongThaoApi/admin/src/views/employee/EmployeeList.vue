<template>
    <div class="employee">
        <header-basic>Danh sách nhân viên </header-basic>
        <div class="employee-header-function">
           <input-search />
           <button-refresh />
        </div>
        
    </div>
</template>
<script>
import HeaderBasic from '../../components/basic/HeaderBasic.vue'
import ButtonRefresh from '../../components/basic/ButtonRefresh.vue'
import InputSearch from '../../components/basic/InputSearch.vue'
export default {
  components: { 
    HeaderBasic,
    ButtonRefresh,
    InputSearch 
    },
    
}
</script>
<style scoped>
.employee-header-function{
    display: flex;
    margin-top: 20px;
    justify-content: space-between;
}
</style>