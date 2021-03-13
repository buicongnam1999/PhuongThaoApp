<template>
    <div class="account">
        <header-basic>Danh sách Tài khoản</header-basic>
        <div class="account-header-function">
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
    components:{
        HeaderBasic,
        InputSearch,
        ButtonRefresh
    }
}
</script>

<style scoped>
.account-header-function{
    display: flex;
    margin-top: 20px;
    justify-content: space-between;
}
</style>